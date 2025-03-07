using static System.Console;
using Packt.Shared;

namespace PracticalApps;
    public class Startup
    {
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddRazorPages();
            services.AddNorthwindContext();
        }
        public void Configure(
        IApplicationBuilder app, IWebHostEnvironment env)
        {
        if (!env.IsDevelopment())
        {
        app.UseHsts();
        }
        app.UseRouting(); // start endpoint routing
        app.UseHttpsRedirection();
        app.UseDefaultFiles();
        app.UseStaticFiles();
        app.UseEndpoints(endpoints =>
        {
            endpoints.MapRazorPages();
            endpoints.MapGet("/hello", () => "Hello World!");
        });
        }
    }
