using System;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.UI;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Recipe_Now.Data;

[assembly: HostingStartup(typeof(Recipe_Now.Areas.Identity.IdentityHostingStartup))]
namespace Recipe_Now.Areas.Identity
{
    public class IdentityHostingStartup : IHostingStartup
    {
        public void Configure(IWebHostBuilder builder)
        {
            builder.ConfigureServices((context, services) => {
                services.AddDbContext<Recipe_NowContext>(options =>
                    options.UseSqlite(
                        context.Configuration.GetConnectionString("Recipe_NowContextConnection")));

                services.AddDefaultIdentity<IdentityUser>(options => options.SignIn.RequireConfirmedAccount = true)
                    .AddEntityFrameworkStores<Recipe_NowContext>();
            });
        }
    }
}