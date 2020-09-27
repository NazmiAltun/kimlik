using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Diagnostics.HealthChecks;

namespace Kimlik.Extensions
{
    internal static class ApplicationBuilderExtensions
    {
        public static IApplicationBuilder UseEndpoints(this IApplicationBuilder app)
        {
            return app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
                endpoints.MapHealthChecks("/healthz", new HealthCheckOptions()
                {
                    Predicate = (_) => true
                });
                endpoints.MapHealthChecks("/health", new HealthCheckOptions
                {
                    Predicate = (check) => check.Tags.Contains("self")
                });
            });
        }
    }
}
