using Curiosityshop.Data;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Curiosityshop
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        // For more information on how to configure your application, visit https://go.microsoft.com/fwlink/?LinkID=398940
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddRazorPages();
            services.AddServerSideBlazor();
            services.AddSingleton<WeatherForecastService>();
            services.AddScoped<Data.Service.IDevolucionService, Data.Service.DevolucionService>();
            services.AddScoped<Data.Service.IFacturaService, Data.Service.FacturaService>();
            services.AddScoped<Data.Service.IFacturaProductoService, Data.Service.FacturaProductoService>();
            services.AddScoped<Data.Service.IDevolucionProductoService, Data.Service.DevolucionProductoService>();
            services.AddScoped<Data.Service.IProductoService, Data.Service.ProductoService>();
            services.AddScoped<Data.Service.IClienteService, Data.Service.ClienteService>();
            var SqlConnectionConfiguration = new SqlConnectionConfiguration(Configuration.GetConnectionString("SqlDBContext"));
            //Patr�n Singleton
            services.AddSingleton(SqlConnectionConfiguration);


        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            else
            {
                app.UseExceptionHandler("/Error");
                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                app.UseHsts();
            }

            app.UseHttpsRedirection();
            app.UseStaticFiles();

            app.UseRouting();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapBlazorHub();
                endpoints.MapFallbackToPage("/_Host");
            });
        }
    }
}
