using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using Microsoft.OpenApi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Ultima
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddAuthorization();
            services.AddControllers();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseHttpsRedirection();

            app.UseRouting();

            app.UseAuthorization();

            app.UseEndpoints(eP => eP.MapControllers());

            app.Map("/discord", builder =>
            {
                builder.Run(handler =>
                {
                    handler.Response.Redirect("https://www.discord.gg/kdmJJWNVvp");
                    return Task.CompletedTask;
                });
            });
            app.Map("/github", builder =>
            {
                builder.Run(handler =>
                {
                    handler.Response.Redirect("https://www.github.com/n-Ultima");
                    return Task.CompletedTask;
                });
            });
            app.Map("/ranch", builder =>
            {
                builder.Run(handler =>
                {
                    handler.Response.Redirect("https://www.google.com/maps/place/Barclay+Ranch/@38.2178412,-89.0419849,17z/data=!3m1!4b1!4m5!3m4!1s0x8876c35dbba4bec5:0x869579b960a535a2!8m2!3d38.2178413!4d-89.0397437");
                    return Task.CompletedTask;
                });
            });
        }
    }
}
