using Entities.Concrete;
using Microsoft.EntityFrameworkCore;

namespace DataAccess.Concrete.EntityFramework
{
    public class BookStoreContext:DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer
                (@"Server=(localdb)\mssqllocaldb;
                        Database=BookStore;Trusted_Connection=true");
        }

        public DbSet<Book> Books { get; set; } // bu şu demek: benim book ismindew bir veritabanı nesnem var ve bu nesne veritabanında books isimli tabloya karşılık geliyor..
    }
}
