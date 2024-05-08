using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using OnlineHelpDesk.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OnlineHelpDesk
{
    public class Program
    {
        public static void Main(string[] args)
        {
            CreateHostBuilder(args).Build().Run();
        }

        public static IHostBuilder CreateHostBuilder(string[] args) =>
            Host.CreateDefaultBuilder(args)
                .ConfigureWebHostDefaults(webBuilder =>
                {
                    webBuilder.ConfigureServices((context, services) =>
                    {
                        services.AddAuthentication(CookieAuthenticationDefaults.AuthenticationScheme).AddCookie(options =>
                        {
                            options.LoginPath = "/Login/Index";
                            options.AccessDeniedPath = "/Login/AccessDenied";
                        });

                        services.AddSession();

                        services.AddMvc(option => option.EnableEndpointRouting = false);
                        services.AddMvc().AddSessionStateTempDataProvider();

                        var connection = context.Configuration.GetConnectionString("DefaultConnection");
                        services.AddDbContext<OnlineHelpDeskEntities>(options => options.UseLazyLoadingProxies().UseSqlServer(connection));

                        // Add the email services
                      services.AddTransient<IEmailSender, EmailSender>();

                        // Add  additional services 
                    })
                    .Configure((context, app) =>
                    {
                        if (context.HostingEnvironment.IsDevelopment())
                        {
                            app.UseDeveloperExceptionPage();
                        }

                        app.UseAuthentication();
                        app.UseSession();
                        app.UseStaticFiles();

                        app.UseMvc(routes =>
                        {
                            routes.MapRoute(
                                name: "default",
                                template: "{controller=Login}/{action=Index}/{id?}");
                        });

                        // Add any additional middleware configurations needed for your application
                    });
                });
    }
}
