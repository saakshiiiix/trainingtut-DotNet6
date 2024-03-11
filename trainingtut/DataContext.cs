global using Microsoft.EntityFrameworkCore;

namespace trainingtut
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext>options) : base(options) { }
        public  DbSet<superhero> SuperHeroes { get; set; }
    }
}
