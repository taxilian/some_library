using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Community.CsharpSqlite.SQLiteClient;

namespace Library
{
    class OurPatron : Patron
    {
        private Community.CsharpSqlite.SQLiteClient.SqliteConnection conn;

        public OurPatron(Community.CsharpSqlite.SQLiteClient.SqliteConnection conn, int id)
        {
            this.conn = conn;
            this.id = id;
        }
        public int id { get; set; }
        public string name { get; set; }
        public PatronType type { get; set; }

        internal static Patron get(int patron_id, Community.CsharpSqlite.SQLiteClient.SqliteConnection conn)
        {
            SqliteCommand cmd = new SqliteCommand(
                string.Format("select id, name, type from patron where id = {0}", patron_id), conn);
            SqliteDataReader rdr = cmd.ExecuteReader();
            while (rdr.NextResult())
            {
                OurPatron p = new OurPatron(conn, rdr.GetInt32(0));
                p.name = rdr.GetString(1);
                p.type = (PatronType)rdr.GetInt32(2);
                return p;
            }
            return null;
        }
        internal static List<Patron> getAll(SqliteConnection conn)
        {
            List<Patron> plist = new List<Patron>();

            SqliteCommand cmd = new SqliteCommand("select id, name, type from patron order by name", conn);
            SqliteDataReader rdr = cmd.ExecuteReader();
            while (rdr.NextResult())
            {
                OurPatron p = new OurPatron(conn, rdr.GetInt32(0));
                p.name = rdr.GetString(1);
                p.type = (PatronType)rdr.GetInt32(2);
            }

            return plist;
        }
    }
}
