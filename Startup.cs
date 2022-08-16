using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Cakes_N_Treats_By_Zannie.Context;
using Cakes_N_Treats_By_Zannie.Implementations.Repositories;
using Cakes_N_Treats_By_Zannie.Implementations.Repository;
using Cakes_N_Treats_By_Zannie.Implementations.Services;
using Cakes_N_Treats_By_Zannie.Interfaces.IRepositories;
using Cakes_N_Treats_By_Zannie.Interfaces.IServices;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
namespace Cakes_N_Treats_By_Zannie
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

            services.AddAuthentication(CookieAuthenticationDefaults.AuthenticationScheme)
             .AddCookie(config =>
             {
                 config.LoginPath = "/User/Login";
                 config.LogoutPath = "/User/Logout";
                 config.Cookie.Name = "CakesNTreatsByZannie";
             });
            services.AddHttpContextAccessor();
        
            services.AddDbContext<ZannieContext>(options => 
            options.UseMySQL(Configuration.GetConnectionString("ZannieContext")));            
            services.AddControllersWithViews();
            services.AddScoped<ITreatService ,TreatService> ();
            services.AddScoped<ICategoryRepository, CategoryRepository> (); 
             services.AddScoped<ITreatRepository, TreatRepository> (); 
              services.AddScoped<ICategoryService, CategoryService> (); 
               services.AddScoped<IOrderRepository, OrderRepository> (); 
              services.AddScoped<IOrderService, OrderService> (); 
               services.AddScoped<IUserRepository, UserRepository> (); 
              services.AddScoped<IUserService, UserService> (); 
                services.AddScoped<ITreatOrderRepository, TreatOrderRepository> (); 
             services.AddScoped<ICommentRepository, CommentRepository>(); 
              services.AddScoped<ICommentService, CommentService>(); 
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
            app.UseAuthentication();
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
