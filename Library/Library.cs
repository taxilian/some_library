using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Library
{
    public interface Library
    {
        void OpenLibrary(string filename);
        List<MediaItem> GetMediaItems();
        List<Patron> GetAllPatrons();
        List<MediaItem> GetCheckedOutMedia(Patron p = null);

        void save(MediaItem item);
        void save(Patron item);
    }
}
