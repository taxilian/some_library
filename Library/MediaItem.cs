using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Library
{
    public enum MediaType
    {
        Adult_book,
        Childs_book,
        Video
    };
    public interface MediaItem
    {
        public MediaType type { get; set; }
        public string name { get; set; }
        public Patron checked_to { get; set; }
        public DateTime checkout_date { get; set; }
        public DateTime due_date { get; set; }
    };
}
