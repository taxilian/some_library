﻿using System;
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
            string connectionString = string.Format("Data Source=file://{0}", filename);
            conn = new SqliteConnection(connectionString);
            conn.Open();
        }
        public List<MediaItem> GetMediaItems()
        {
            return OurMediaItem.getItems(conn);
        }

        public List<Patron> GetAllPatrons()
        {
            return OurPatron.getAll(conn);
        }

        public List<MediaItem> GetCheckedOutMedia(Patron p = null)
        {
            return OurMediaItem.getCheckedOutItems(conn, p);
        }

        public void save(MediaItem item)
        {
            (item as OurMediaItem).save(conn);
        }
        public void save(Patron item)
        {
            (item as OurPatron).save(conn);
        }
    }
}
