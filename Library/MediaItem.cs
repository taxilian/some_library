using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Library
{
    public enum MediaType
    {
        Adult_book = 1,
        Childs_book,
        Video
    };
    public interface MediaItem
    {
        MediaType type { get; set; }
        string name { get; set; }
        Patron checked_to { get; set; }
        DateTime checkout_date { get; set; }
        DateTime due_date { get; set; }
    };
}
