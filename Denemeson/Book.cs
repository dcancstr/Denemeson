using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Denemeson
{
    internal class Book
    {
        public int Id { get; set; }
        public string Bookname { get; set; }
        public decimal Price { get; set; }
        public string Category { get; set; }
        public int Numberofpage { get; set; }
        public int Stock { get; set; }

        public Author authors { get; set; }
    }
}
