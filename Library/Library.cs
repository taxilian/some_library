using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Library
{
    public interface Library
    {
        void OpenLibrary(string filename);
        List<MediaItem> GetMediaItems(Patron p = null);
        List<Patron> GetAllPatrons();
        List<MediaItem> GetCheckedOutMedia();
    }
}
