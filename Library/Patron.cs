using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Library
{
    public enum PatronType { Adult=1, Child };
    public interface Patron
    {
        string name { get; set; }
        PatronType type { get; set; }
    };
}
