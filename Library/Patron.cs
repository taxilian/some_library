using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Library
{
    public enum PatronType { Adult, Child };
    class Patron
    {
        public string name { get; set; }
        public PatronType type { get; set; }
    };
}
