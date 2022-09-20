using Data.Models;
using Microsoft.EntityFrameworkCore;
using System.Reflection;

namespace Data.Database
{
    public class WorldMoodDbContext : DbContext
    {
        public WorldMoodDbContext(DbContextOptions<WorldMoodDbContext> options)
            : base(options)
        {

        }
        public DbSet<CountryMood> CountryMoods { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<Country> Countries { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
        }

    }

}
