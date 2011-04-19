using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Community.CsharpSqlite.SQLiteClient;

namespace Library
{
    class OurLibrary : Library
    {
        SqliteConnection conn;

        public void assertConnection()
        {
            if (conn == null)
                throw new System.InvalidOperationException("Database not selected");
        }
        public void OpenLibrary(string filename)
        {
            string connectionString = string.Format("Data Source={0}", filename);
            conn = new SqliteConnection(connectionString);
            conn.Open();
        }
        public List<MediaItem> GetMediaItems(Patron p = null)
        {
            return OurMediaItem.getItems(conn);
        }

        public List<Patron> GetAllPatrons()
        {
            return OurPatron.getAll(conn);
        }

        public List<MediaItem> GetCheckedOutMedia()
        {
            return OurMediaItem.getCheckedOutItems(conn);
        }
    }
}
