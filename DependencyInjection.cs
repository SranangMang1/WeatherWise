using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Configuration;
using NeinLinq;
using WeatherWise.Objects;
using static WeatherWise.WeatherContext;

namespace WeatherWise
{
    public static class DependencyInjection
    { 
        public static IServiceCollection AddWeatherDbContextFactory(this IServiceCollection service, IServiceCollection services, IConfiguration configuration, bool isDevelopment)
        {
            services.AddDbContext<WeatherContext>(options =>
            {
                options.UseSqlServer(configuration.GetConnectionString("WeatherConnection"),
                    b =>
                    {
                        b.EnableRetryOnFailure();
                    });
                options.EnableSensitiveDataLogging(isDevelopment);
                
            });

            return services;

        }

       

        public static IServiceCollection RegisterLocalization(this IServiceCollection services)
        {
            services.AddLocalization();

            return services;
        }

       

    }
}
