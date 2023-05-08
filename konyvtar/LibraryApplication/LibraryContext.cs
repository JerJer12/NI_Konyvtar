using LibraryApplication.Contracts;
using Microsoft.EntityFrameworkCore;

namespace LibraryApplication.Api
{
    public class LibraryContext : DbContext
    {
        public LibraryContext(DbContextOptions options)
            : base(options)
        {
        }

        public virtual DbSet<User> Users { get; set; }

        public virtual DbSet<Book> Books { get; set; }

        public virtual DbSet<Borrow> Borrows { get; set; }
    }
}
