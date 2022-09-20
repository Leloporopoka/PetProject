using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace Data.Database
{
    public static class DatabaseConfig
    {
        public static void SetupDatabase(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddDbContext<WorldMoodDbContext>(options => options.UseNpgsql(configuration.GetConnectionString("DatabaseConnection")));
        }

    }
}
