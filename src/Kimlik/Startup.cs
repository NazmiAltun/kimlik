using Kimlik.Extensions;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.DependencyInjection;

namespace Kimlik
{
    public class Startup
    {
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddCustomHealthChecks();
            services.AddControllers();
        }

        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            app.UseRouting()
                .UseEndpoints();
        }
    }
}
