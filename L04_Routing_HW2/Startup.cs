using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Routing;
using Microsoft.AspNetCore.Routing.Patterns;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

namespace L04_Routing_HW2
{
    public class Startup
    {
        // This method gets called by the runtime. Use this method to add services to the container.
        // For more information on how to configure your application, visit https://go.microsoft.com/fwlink/?LinkID=398940
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddRouting();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            var routeBuilder = new RouteBuilder(app);

            routeBuilder.MapRoute("{controller}/{action}/{*catchall}",
                async context => {

                    RouteData routeData = context.GetRouteData();

                    bool routeContainsDigits = false;

                    foreach (var item in routeData.Values)
                    {
                        if (Regex.Match(item.Value.ToString(), @"\d+").Success)
                        {
                            routeContainsDigits = true;
                            await context.Response.WriteAsync($"{item}/");
                        }
                    }
                    
                    if (!routeContainsDigits)
                    {
                        throw new RoutePatternException("{controller}/{action}/{*catchall}",
                            "At least one of the sections of the route must contain a digit.");
                    }
                });

            routeBuilder.MapRoute("/",
                        async context =>
                        {
                            await context.Response.WriteAsync("Home page.");
                        });

            app.UseRouter(routeBuilder.Build());


            //app.UseRouting();

            //app.UseEndpoints(endpoints =>
            //{
            //    endpoints.MapGet("/", async context =>
            //    {
            //        await context.Response.WriteAsync("Hello World!");
            //    });
            //});
        }
    }
}
