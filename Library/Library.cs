using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Library
{
    public interface Library
    {
        List<MediaItem> GetMediaItems(Patron p = null);
        List<MediaItem> GetAllPatrons();
        List<MediaItem> GetCheckedOutMedia();
    }
}
