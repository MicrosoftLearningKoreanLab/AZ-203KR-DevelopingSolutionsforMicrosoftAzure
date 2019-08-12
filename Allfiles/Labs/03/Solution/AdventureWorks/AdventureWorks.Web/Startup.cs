using AdventureWorks.Context;
using AdventureWorks.Web.Configuration;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace AdventureWorks.Web
{
    public class Startup
    {
        private IConfiguration _configuration { get; }

        public Startup(IConfiguration configuration)
        {
            _configuration = configuration;
        }

        public void ConfigureServices(IServiceCollection services)
        {
            services.AddMvc().SetCompatibilityVersion(CompatibilityVersion.Version_2_2);

            services.AddRouting(options => options.LowercaseUrls = true);

            services.Configure<Settings>(
                _configuration.GetSection(nameof(Settings))
            );

            ConfigureProductService(services);
            ConfigureCheckoutService(services);
        }

        public void ConfigureProductService(IServiceCollection services)
        {
            services.AddScoped<IAdventureWorksProductContext, AdventureWorksCosmosContext>(provider =>
                new AdventureWorksCosmosContext(
                    _configuration.GetConnectionString(nameof(AdventureWorksCosmosContext))
                )
            );
        }

        public void ConfigureCheckoutService(IServiceCollection services)
        {
            services.AddScoped<IAdventureWorksCheckoutContext, AdventureWorksRedisContext>(provider =>
                new AdventureWorksRedisContext(
                    _configuration.GetConnectionString(nameof(AdventureWorksRedisContext))
                )
            );
        }

        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            app.UseDeveloperExceptionPage();
            app.UseStaticFiles();
            app.UseMvc();
        }
    }
}