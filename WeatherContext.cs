using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using WeatherWise.Entity;
using WeatherWise.Objects;

namespace WeatherWise
{
    public class WeatherContext : DbContext
    {
        public WeatherContext(DbContextOptions options):base(options)
        { }
        public DbSet<Degrees> Degrees { get; set; }
        public DbSet<RecordDTO> Records { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

            builder.Entity<Degrees>();
        }

        public class WeatherContextDb : IDesignTimeDbContextFactory<WeatherContext>
        {
            public WeatherContext CreateDbContext(string[] args)
            {
                var builder = new DbContextOptionsBuilder<WeatherContext>();
                var connectionString = "Server= ;Database= ;Trusted_Connection=True;TrustServerCertificate=True";
                builder.UseSqlServer(connectionString);
                return new WeatherContext(builder.Options);
            }
        }

    }
}
