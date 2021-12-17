using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace net.tellerapps.sunrise_sunset_client.dependency_injection
{
    /// <summary>
    /// Sunrise sunset extension class
    /// </summary>
    public static class SunriseSunsetClientExtension
    {
        /// <summary>
        /// Add the SunriseSunsetHttpClient, SunriseSunsetService, and a named HttpClient to the Services Collection
        /// </summary>
        /// <param name="services">Services collection</param>
        /// <returns>Services collection</returns>
        public static IServiceCollection AddSunriseSunsetClient(this IServiceCollection services)
        {
            services.AddHttpClient<SunriseSunsetService>();
            services.AddScoped<SunriseSunsetHttpClient>();
            services.AddScoped<SunriseSunsetService>();
            
            return services;
        }
    }
}
