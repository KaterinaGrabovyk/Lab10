using Microsoft.EntityFrameworkCore;

namespace Lab10.DB
{
    public class PlantdbContext:DbContext
    {
        public PlantdbContext(DbContextOptions options) : base(options)
        {
        }
        public DbSet<Plant> Plants => Set<Plant>();
    }
}
