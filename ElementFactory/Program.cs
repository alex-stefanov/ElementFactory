using ElementFactory.Core.Contracts;
using ElementFactory.Core.Extensions;
using ElementFactory.Core.Implementations.Repositories;
using ElementFactory.Core.Implementations.Services;
using ElementFactory.Data;
using ElementFactory.Data.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;

namespace ElementFactory
{
    /// <summary>
    /// Start Point Of The App
    /// </summary>
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            var connectionString = builder
                .Configuration
                .GetConnectionString("DefaultConnection")
                ?? throw new InvalidOperationException
                ("Connection string 'DefaultConnection' " +
                "not found.");
           
            builder
                .Services
                .AddDbContext<ApplicationDbContext>(
                options =>
                {
                    options
                    .UseSqlServer(connectionString);

                    options
                    .EnableSensitiveDataLogging();
                });

            builder
                .Services
                .AddApplicationServices();

            builder
                .Services
                .AddControllersWithViews()
                .AddRazorRuntimeCompilation();

            builder.Services
                .AddDatabaseDeveloperPageExceptionFilter();
           
            builder.Services
                .AddDefaultIdentity<IdentityUser>
                (options =>
                {
                    options
                    .SignIn
                    .RequireConfirmedAccount = false;
                    options.Password.RequiredLength = 5;
                })
                .AddEntityFrameworkStores<ApplicationDbContext>();

            builder.Services.ConfigureApplicationCookie(options =>
            {
                options.LoginPath = "/User/Login";
            });

            builder.Services.AddControllersWithViews();

            var app = builder.Build();
            
            if (app.Environment.IsDevelopment())
            {
                app.UseMigrationsEndPoint();
            }
            else
            {
                app.UseExceptionHandler("/Home/Error");
                app.UseHsts();
            }

            app.UseHttpsRedirection();
            app.UseStaticFiles();

            app.UseRouting();

            app.UseAuthentication();
            app.UseAuthorization();

            app.MapControllerRoute(
                name: "default",
                pattern: "{controller=Home}/{action=Index}/{id?}");

            app.MapRazorPages();

            app.Run();
        }
    }
}