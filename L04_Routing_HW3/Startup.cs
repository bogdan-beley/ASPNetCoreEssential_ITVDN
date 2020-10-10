using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Routing;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.AspNetCore.Routing.Constraints;

namespace L04_Routing_HW3
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

            var routeHandler = new RouteHandler(Handle);
            var routeBuilder = new RouteBuilder(app, routeHandler);

            //routeBuilder.MapGet(
            //    "{controller}/{action}/{id?}",
            //    async context => {
            //        await context.Response.WriteAsync("");
            //    });

            routeBuilder.MapRoute("userRoute", "{controller}/{action}/{id?}",
                null,
                new { controller = @"\d*", action = @"\d*", id = @"\d*" }
                );

            routeBuilder.MapRoute("default", "/");
               
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

        private async Task Handle(HttpContext context)
        {
            RouteData routeData = context.GetRouteData();
            foreach (var item in routeData.Values)
            {
                await context.Response.WriteAsync($"{item}/");
            }
        }
    }
}
