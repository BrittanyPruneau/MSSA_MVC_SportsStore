using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using SportsStore.Models;

namespace SportsStore
{
    public class Startup
    {
        // FIELDS AND PROPERTIES 
        private IConfiguration _configuration { get; }


        // CONSTRUCTORS 
        public Startup(IConfiguration configuration) // Dependency Injection - inversion of control // the ecosystem does this 
        {
            // this constructor goes to the appsettings.json file 
            // saving configuration into a field 
            _configuration = configuration; 
        }
        
        // METHODS 

        // This method gets called by the runtime. Use this method to add services to the container.
        // For more information on how to configure your application, visit https://go.microsoft.com/fwlink/?LinkID=398940
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddDbContext<MagicDbClass>(options =>
                options.UseSqlServer
                    (_configuration
                     .GetConnectionString("DefaultConnection")));


            //  services.AddScoped<IProductRepository, FakeProductRepository>(); // faith when i ask for a IProductRepository it's going to give me a fake reposity. 
            services.AddScoped<IProductRepository, EfProductRepository>();
            services.AddControllersWithViews(); 
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseDeveloperExceptionPage();
            app.UseStatusCodePages();
            app.UseStaticFiles(); 

            app.UseRouting();

            app.UseEndpoints(endpoints =>  // using lambda expression
            {
                endpoints.MapDefaultControllerRoute(); 
            });
        }
    }
}
