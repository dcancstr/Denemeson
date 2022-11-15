using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Denemeson
{
    internal class Sales
    {
        public int Id { get; set; }
        public int Adet { get; set; }
        public DateTime Tarih { get; set; }
        public decimal Price { get; set; }
        public Book book { get; set; }
        public Customer customer { get; set; }
    }
}
