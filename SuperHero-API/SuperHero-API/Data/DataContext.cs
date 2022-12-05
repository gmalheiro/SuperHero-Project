using Microsoft.EntityFrameworkCore;

namespace SuperHero_API.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext>options) : base(options) 
        {
            
        }
        public DbSet<SuperHero> SuperHeroes => Set<SuperHero>();
    }
}
