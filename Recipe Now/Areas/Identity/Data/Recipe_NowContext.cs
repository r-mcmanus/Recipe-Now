using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Recipe_Now.Models;

namespace Recipe_Now.Data
{
    public class Recipe_NowContext : IdentityDbContext<IdentityUser>
    {
        public Recipe_NowContext(DbContextOptions<Recipe_NowContext> options)
            : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.Entity<Following>().HasKey(f => new { f.Follower, f.Followed });
            base.OnModelCreating(builder);
            
            // Customize the ASP.NET Identity model and override the defaults if needed.
            // For example, you can rename the ASP.NET Identity table names and more.
            // Add your customizations after calling base.OnModelCreating(builder);
        }

        public Microsoft.EntityFrameworkCore.DbSet<Following> Followings { get; set; }
    }
}
