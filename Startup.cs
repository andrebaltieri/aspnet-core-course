using Microsoft.AspNet.Builder;
using Microsoft.AspNet.Hosting;
using Microsoft.Extensions.PlatformAbstractions;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Data.Entity;
using AspNetMac.Data;

namespace AspNetMac
{
    public class Startup
    {
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddMvc();    
             
            services.AddEntityFramework()
                .AddInMemoryDatabase()
                .AddDbContext<AppDataContext>(options => options.UseInMemoryDatabase());                       
        }

        public void Configure(IApplicationBuilder app)
        {            
            app.UseStaticFiles();

            app.UseMvc(routes =>
            {
                routes.MapRoute(
                    name: "default",
                    template: "{controller=Home}/{action=Index}/{id?}");
            });
        }
    }
}