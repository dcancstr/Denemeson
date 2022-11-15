using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Denemeson
{
    internal class AuthorContext:DbContext
    {
        public DbSet<Author> authors { get; set; }
        public DbSet<Book> books { get; set; }
        public DbSet<Customer> customers { get; set; }
        public DbSet<Sales> saless { get; set; }

        public AuthorContext() : base("Librarycon")
        {

        }
    }
}
