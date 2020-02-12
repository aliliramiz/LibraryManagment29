using LibraryManagment.Forms;
using LibraryManagment.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManagment.Data
{
   public class LibraryDbContext:DbContext
    {
        public LibraryDbContext():base("LibraryDbContext")
        {

        }
        public DbSet<Book> Books { get; set; }
        public DbSet<Comment> Comments { get; set; }
        public DbSet<Customer> Customers { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<User> Users { get; set; }


    }
}
