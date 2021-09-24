using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyFirstProj
{
    public class Startup
    {
        // This method gets called by the runtime. Use this method to add services to the container.
        // For more information on how to configure your application, visit https://go.microsoft.com/fwlink/?LinkID=398940
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddMvc();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            //default middleware    -   MIDDLEWARE 1
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            //Middleware defined    -   MIDDLEWARE 2
            app.Use(async (context, next) =>
            {
                await context.Response.WriteAsync("First Middleware executed...\n");
                await next();
            });

            //Middleware defined    -   MIDDLEWARE 2
            app.Use(async (context, next) =>
            {
                await context.Response.WriteAsync("Second Middleware executed...\n");
                await next();
            });

            //default middleware whose response is "Hello World!"
            app.Run(async (context) =>
            {
                await context.Response.WriteAsync("Hello World!\n");
            });
        }
    }
}
