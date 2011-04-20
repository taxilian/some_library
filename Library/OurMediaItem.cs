using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Community.CsharpSqlite.SQLiteClient;

namespace Library
{
    class OurMediaItem : MediaItem
    {
        private Community.CsharpSqlite.SQLiteClient.SqliteConnection conn;

        public OurMediaItem(Community.CsharpSqlite.SQLiteClient.SqliteConnection conn, int id)
        {
            // TODO: Complete member initialization
            this.conn = conn;
            this.id = id;
            checked_to_patron_id = -1;
        }
        public int id { get; set; }
        public MediaType type { get; set; }
        public string name { get; set; }
        public Patron checked_to
        {
            get
            {
                if (checked_to_patron_id == -1)
                    return null;
                else
                    return OurPatron.get(checked_to_patron_id, conn);
            }
            set {
                checked_to_patron_id = (value as OurPatron).id;
            }
        }
        public DateTime? checkout_date { get; set; }
        public DateTime? due_date { get; set; }

        public int checked_to_patron_id {get; set;}

        public void save(SqliteConnection conn)
        {
            string command;
            if (id == -1)
                command = "insert into mediaitem (name, type, checked_to_patron_id, " +
                          " checkout_date, due_date) values (@name, @type, @patron_id, @co_date, @due_date);";
            else
                command = "update mediaitem set name=@name, type=@type, checked_to_patron_id=@patron_id, " +
                          " checkout_date=@co_date, due_date=@due_date where id=@id";
            SqliteCommand cmd = new SqliteCommand(command, conn);
            cmd.Parameters.Add("@id", id);
            cmd.Parameters.Add("@name", name);
            cmd.Parameters.Add("@type", type);
            if (checked_to_patron_id > -1)
                cmd.Parameters.Add("@patron_id", checked_to_patron_id);
            if (checkout_date != null)
                cmd.Parameters.Add("@co_date", checkout_date.Value.ToString());
            if (due_date != null)
                cmd.Parameters.Add("@due_date", due_date);

            cmd.ExecuteNonQuery();
            //id = cmd.LastInsertRowID();
        }

        internal static List<MediaItem> getItems(SqliteConnection conn, string where = "")
        {
            List<MediaItem> iList = new List<MediaItem>();

            SqliteCommand cmd = new SqliteCommand(
                string.Format("select id, name, type, checked_to_patron_id, " + 
                "checkout_date, due_date from mediaitem {0} order by name", where), conn);
            SqliteDataReader rdr = cmd.ExecuteReader();
            while (rdr.NextResult())
            {
                OurMediaItem i = new OurMediaItem(conn, rdr.GetInt32(0));
                i.name = rdr.GetString(1);
                i.type = (MediaType)rdr.GetInt32(2);
                if (!rdr.IsDBNull(3))
                {
                    i.checked_to_patron_id = rdr.GetInt32(3);
                }
                if (!rdr.IsDBNull(4))
                {
                    i.checkout_date = DateTime.Parse(rdr.GetString(4));
                }
                if (!rdr.IsDBNull(5))
                {
                    i.due_date = DateTime.Parse(rdr.GetString(5));
                }
                iList.Add(i);
            }
            return iList;
        }

        internal static List<MediaItem> getCheckedOutItems(SqliteConnection conn)
        {
            return getItems(conn, "where checked_to_patron_id is not null");
        }
    }
}
