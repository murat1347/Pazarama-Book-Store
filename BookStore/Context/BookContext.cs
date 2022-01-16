using BookStore.Models;
using Microsoft.EntityFrameworkCore;

namespace BookStore.Context
{
    public class BookContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=(localdb)\\mssqllocaldb;Database=BookDb;Trusted_Connection=True;");
        }

        public DbSet<Book> Books { get; set; }

        public DbSet<Category> Categories { get; set; }
        public DbSet<Admin> Admins { get; set; }

    }
}
