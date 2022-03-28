using dvs5_paskaita_EntityFrameworkCore.Models;
using Microsoft.EntityFrameworkCore;

namespace dvs5_paskaita_EntityFrameworkCore.Contexts
{
    public class BookContext : DbContext
    {
        public DbSet<Page> Pages { get; set; }
        public DbSet<Book> Books { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder options)
            => options.UseSqlServer($"Server=localhost;Database=dvs05_lecture_Book;Trusted_Connection=True;");
    }
}
