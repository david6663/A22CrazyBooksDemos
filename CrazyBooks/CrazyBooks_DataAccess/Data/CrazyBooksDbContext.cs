using CrazyBooks_Models.Models;  //ADD DEMO 2 (apres ajouter reference objet right click)
using CrazyBooks_Models.Models;
using Microsoft.EntityFrameworkCore;

namespace CrazyBooks_DataAccess.Data
{
    public class CrazyBooksDbContext:DbContext
    {

        public DbSet<Subject> Subject { get; set; }
        public DbSet<Book> Book { get; set; }
        public DbSet<Publisher> Publisher { get; set; }
        public DbSet<Author> Author { get; set; }
        public DbSet<AuthorDetail> AuthorDetail { get; set; }


        public CrazyBooksDbContext(DbContextOptions<CrazyBooksDbContext> options) : base(options)
    {
           
    }

    }
}
