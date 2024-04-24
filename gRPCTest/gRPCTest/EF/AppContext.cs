using Microsoft.EntityFrameworkCore;

namespace gRPCTest.EF
{
    public class AppContext : DbContext
    {
        public DbSet<PhraseEF> Phrases => Set<PhraseEF>();
        public AppContext() => Database.EnsureCreated();

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseNpgsql("Host=localhost;Port=5432;Database=postgres;Username=postgres;Password=postgres");
        }
    }
}
