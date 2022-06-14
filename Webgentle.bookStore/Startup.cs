using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

namespace Webgentle.bookStore
{
    public class Startup
    {
        // This method gets called by the runtime. Use this method to add services to the container.
        // For more information on how to configure your application, visit https://go.microsoft.com/fwlink/?LinkID=398940
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddControllersWithViews();
        } 

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            /*app.Use(async (context, next) =>
            {
                await context.Response.WriteAsync("hello from middleware one || ");
                await next();
                await context.Response.WriteAsync("hello from middleware one afterwords || ");
            });
            
            app.Use(async (context, next) =>
            {
                await context.Response.WriteAsync("hello from middleware two || ");
                await next();
                await context.Response.WriteAsync("hello from middleware two afterwords || ");

            });
            
            app.Use(async (context, next) =>
            {
                await context.Response.WriteAsync("hello from middleware three || ");
                await next();
            });*/

            app.UseRouting();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapDefaultControllerRoute();
            });
            
            
        }
    }
}