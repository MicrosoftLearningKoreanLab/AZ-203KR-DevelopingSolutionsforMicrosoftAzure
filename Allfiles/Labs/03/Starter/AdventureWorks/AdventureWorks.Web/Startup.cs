using AdventureWorks.Context;
using AdventureWorks.Web.Configuration;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Moq;

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
            services.AddScoped<IAdventureWorksProductContext, AdventureWorksSqlContext>(provider =>
                new AdventureWorksSqlContext(
                    _configuration.GetConnectionString(nameof(AdventureWorksSqlContext))
                )
            );
        }

        public void ConfigureCheckoutService(IServiceCollection services)
        {
            services.AddScoped<IAdventureWorksCheckoutContext>(provider =>
                new Mock<IAdventureWorksCheckoutContext>().Object
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