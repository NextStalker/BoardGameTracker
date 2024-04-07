using BGT.Domain;
using Microsoft.EntityFrameworkCore;

namespace BGT.Persistence
{
    public class GamesContext : DbContext
    {
        public DbSet<Game> Games { get; set; } = null!;

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.ApplyConfiguration(new GameConfiguration());
        }
    }
}
