using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.IO;
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
            List<Recipe> recipes = new List<Recipe>();
            //Testing recipe list
            var recipeFile = File.ReadAllLines("Recipes.txt");
            int i = 0;
            while (i < recipeFile.Length)
            {
                Recipe recipe = new Recipe();
                recipe.IsDrink = bool.Parse(recipeFile[i]);
                recipe.URL = recipeFile[i + 1];
                recipe.Name = recipeFile[i + 2];
                recipe.ImagePath = recipeFile[i + 3];
                string ingredients = recipeFile[i + 4].Remove(0, 1);
                recipe.Ingredients = ingredients;
                //recipe.Ingredients = recipeFile[i + 4];
                //string ingredients = recipeFile[i + 4].Remove(0, 2);                       
                //recipe.Ingredients = ingredients.Split("', '").ToList();           
                recipes.Add(recipe);
                i = i + 6;
            }

            builder.Entity<Following>().HasKey(f => new { f.Follower, f.Followed });
            foreach (var r in recipes)
            {
                builder.Entity<Recipe>().HasData(new Recipe[] {
               
                new Recipe{Name=r.Name,URL=r.URL,ImagePath=r.ImagePath,Ingredients=r.Ingredients,IsDrink=r.IsDrink}
                //new User{UserId=2,Name="Alex"},
            });
            }
            base.OnModelCreating(builder);
            
            // Customize the ASP.NET Identity model and override the defaults if needed.
            // For example, you can rename the ASP.NET Identity table names and more.
            // Add your customizations after calling base.OnModelCreating(builder);
        }
        public Microsoft.EntityFrameworkCore.DbSet<Recipe> Recipes { get; set; }
        public Microsoft.EntityFrameworkCore.DbSet<Following> Followings { get; set; }
    }
}
