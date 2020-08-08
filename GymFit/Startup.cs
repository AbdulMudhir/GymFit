using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using GymFit.Models;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

namespace GymFit
{
    public class Startup
    {
        // This method gets called by the runtime. Use this method to add services to the container.
        // For more information on how to configure your application, visit https://go.microsoft.com/fwlink/?LinkID=398940

        private readonly IConfiguration Configuration;
        public Startup(IConfiguration configuration)
        {

            Configuration = configuration;
        }

        public void ConfigureServices(IServiceCollection services)
        {


            services.AddControllers().AddNewtonsoftJson(options =>
                options.SerializerSettings.ReferenceLoopHandling = Newtonsoft.Json.ReferenceLoopHandling.Ignore
            );
           
            
            services.AddRazorPages().AddRazorRuntimeCompilation();
            services.AddControllersWithViews().AddJsonOptions(opts => opts.JsonSerializerOptions.PropertyNamingPolicy = null);


            services.AddScoped<ICategoryRepository, CategoryRepository>();
            services.AddScoped<IProductRepository, ProductRepository>();
            services.AddScoped<ShoppingCart>( sp => ShoppingCart.createShoppingCart(sp));

            services.AddHttpContextAccessor();
            services.AddDistributedMemoryCache();
            services.AddSession();

            services.AddDbContext<DatabaseContext>(options => options.UseSqlServer(

                Configuration.GetConnectionString("DefaultConnection")


              ));



        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
                app.UseBrowserLink();
            }
            app.UseSession();
            app.UseStaticFiles();
            app.UseHttpsRedirection();
            app.UseRouting();

          

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllerRoute(
                     name: "Default",
                     pattern: "{Controller=Home}/{Action=Index}/{id?}"


                     );

            });
        }
    }
}
