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
        }
        public int id { get; set; }
        public MediaType type { get; set; }
        public string name { get; set; }
        public Patron checked_to {
            get {
                return OurPatron.get(checked_to_patron_id, conn);
            }
            set {
            }
        }
        public DateTime checkout_date { get; set; }
        public DateTime due_date { get; set; }

        public int checked_to_patron_id {get; set;}

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
