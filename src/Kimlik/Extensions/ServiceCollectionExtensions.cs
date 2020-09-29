using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Diagnostics.HealthChecks;

namespace Kimlik.Extensions
{
    public static class ServiceCollectionExtensions
    {
        public static IServiceCollection AddCustomHealthChecks(this IServiceCollection services)
        {
            services.AddHealthChecks()
                .AddCheck("self", 
                    () => HealthCheckResult.Healthy("OK!"), 
                    new[] { "self" });

            return services;
        }
    }
}
