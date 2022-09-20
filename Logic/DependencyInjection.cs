using Logic.Interfaces;
using Logic.Services;
using Microsoft.Extensions.DependencyInjection;

namespace Logic
{
    public static class DependencyInjection
    {
        public static void AddLogicServices(this IServiceCollection services)
        {
            services.AddScoped<IUserService, UserService>();
            services.AddScoped<ICountryMoodService, CountryMoodService>();
        }
    }
}
