using CakesMarket.DBContext;
using CakesMarket.Models;
using CakesMarket.Models.Repository;
using CakesMarket.Models.Services;
using CakesMarket.Web.Profiles;
using CakesMarket.Web.Repository;
using CakesMarket.Web.Service;
using CakesMarket.Web.UOfWork;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

namespace CakesMarket
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
            string dbConnectionString = Configuration.GetConnectionString(ConnectionDB.DbConnectionString);
            services.AddDbContext<DatabaseContext>(options => options.UseSqlServer(dbConnectionString).UseLazyLoadingProxies(true));
            services.AddScoped<ICakeRepository, CakeRepository>();
            services.AddScoped<IUnitOfWork, UnitOfWork>();
            services.AddScoped<ICategoryRepository, CategoryRepository>();
            services.AddScoped<IIngridientRepository, IngridientRepository>();
            services.AddScoped<ICakeService, CakeService>();
            services.AddAutoMapper((serviceProvider, mapper) =>
            {
                mapper.AddProfile(new MappingProfile());
            }, typeof(Startup));
            services.AddControllersWithViews();
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
                app.UseExceptionHandler("/Home/Error");
                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                app.UseHsts();
            }
            app.UseHttpsRedirection();
            app.UseStaticFiles();

            app.UseRouting();

            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllerRoute(
                    name: "default",
                    pattern: "{controller=Home}/{action=Index}/{id?}");
            });
        }
    }
}
