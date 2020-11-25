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
        public Microsoft.EntityFrameworkCore.DbSet<Recipe> Recipes { get; set; }
        public Microsoft.EntityFrameworkCore.DbSet<Ingredient> Ingredients { get; set; }
        public Microsoft.EntityFrameworkCore.DbSet<Like> Likes { get; set; }
        public Recipe_NowContext(DbContextOptions<Recipe_NowContext> options)
            : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            //builder.Entity<Ingredient>().HasKey(i => new
            //{
            //    i.Description,
            //    i.RecipeId
            //});


            List<Recipe> recipes = new List<Recipe>();

            //Testing recipe list
            char[] trimChars = { '[', ']', '\'' };
            var recipeFile = File.ReadAllLines("Recipes.txt");
            int i = 0;
            int x = 1;
            int y = 1;
            while (i < recipeFile.Length)
            {
                Recipe recipe = new Recipe();
                List<Ingredient> ingredients = new List<Ingredient>();
                List<string> ingDesc = new List<string>();
                recipe.RecipeId = x;
                recipe.IsDrink = bool.Parse(recipeFile[i]);
                recipe.URL = recipeFile[i + 1];
                recipe.Name = recipeFile[i + 2];
                recipe.ImagePath = recipeFile[i + 3];
                ingDesc = recipeFile[i + 4].Trim(trimChars).Split("', '").ToList();
                foreach (var j in ingDesc)
                {
                    Ingredient ingredient = new Ingredient();
                    ingredient.IngredientId = y;
                    ingredient.Description = j;
                    ingredient.RecipeId = x;
                    ingredients.Add(ingredient);
                    recipe.Ingredients = ingredients;
                    y++;
                }
                //string ingredientsWithEnd = recipeFile[i + 4].Remove(0, 1);
                //string ingredients = ingredientsWithEnd.t
                //recipe.Ingredients = ingredients;
                //recipe.Ingredients = recipeFile[i + 4];
                //string ingredients = recipeFile[i + 4].Remove(0, 2);                       
                //recipe.Ingredients = ingredients.Split("', '").ToList();           
                recipes.Add(recipe);
                i = i + 6;
                x++;
            }
            //List<Recipe> recipes = new List<Recipe>();
            ////Testing recipe list
            //var recipeFile = File.ReadAllLines("Recipes.txt");
            //int i = 0;
            //while (i < recipeFile.Length)
            //{
            //    Recipe recipe = new Recipe();
            //    recipe.IsDrink = bool.Parse(recipeFile[i]);
            //    recipe.URL = recipeFile[i + 1];
            //    recipe.Name = recipeFile[i + 2];
            //    recipe.ImagePath = recipeFile[i + 3];
            //    string ingredients = recipeFile[i + 4].Remove(0, 1);
            //    recipe.Ingredients = ingredients;
            //    //recipe.Ingredients = recipeFile[i + 4];
            //    //string ingredients = recipeFile[i + 4].Remove(0, 2);                       
            //    //recipe.Ingredients = ingredients.Split("', '").ToList();           
            //    recipes.Add(recipe);
            //    i = i + 6;
            //}
            //i = 1;
            //int x = 1;
            //builder.Entity<Following>().HasKey(f => new { f.Follower, f.Followed });
            //foreach (var ing in ingredients)
            //{
            //    builder.Entity<Ingredient>().HasData(new Ingredient[] {
            //            new Ingredient{IngredientId = ing.IngredientId, Description = ing.Description, RecipeId = r.RecipeId}
            //        });
            //}
            //builder.Entity<Recipe>().HasMany(ingr => ingr.Ingredients);
            //builder.Entity<Ingredient>()
            foreach (var r in recipes)
            {

                //        builder.Entity<Recipe>(b =>
                //        {
                //            //b.HasData(new Recipe
                //            //{
                //            //    RecipeId = r.RecipeId,
                //            //    Name = r.Name,
                //            //    URL = r.URL,
                //            //    ImagePath = r.ImagePath,
                //            //    //Ingredients = r.Ingredients,
                //            //    IsDrink = r.IsDrink
                //            //});

                //            b.OwnsMany(r => r.Ingredients).HasData(new Ingredient
                //            {
                //                foreach (var ing in r.Ingredients)
                //                 { }
                //                //IngredientId = ing.IngredientId,
                //                //Description = ing.Description,
                //                //RecipeId = ing.RecipeId
                //            }
                //        });
                //    }/*);*/

                //}
                //    );
                //}});
                //});

                builder.Entity<Recipe>().HasData(new Recipe
                {
                    RecipeId = r.RecipeId,
                    Name = r.Name,
                    URL = r.URL,
                    ImagePath = r.ImagePath,
                    //Ingredients = r.Ingredients,
                    IsDrink = r.IsDrink
                }
                );

                foreach (var ing in r.Ingredients)
                {
                    builder.Entity<Ingredient>()
                        .HasData(new Ingredient
                        {
                            IngredientId = ing.IngredientId,
                            Description = ing.Description,
                            RecipeId = ing.RecipeId
                        }
                    );
                }
                //i++;
                //new User{UserId=2,Name="Alex"},

            }
            base.OnModelCreating(builder);
            
            // Customize the ASP.NET Identity model and override the defaults if needed.
            // For example, you can rename the ASP.NET Identity table names and more.
            // Add your customizations after calling base.OnModelCreating(builder);
        }
        //public Microsoft.EntityFrameworkCore.DbSet<Recipe> Recipes { get; set; }
       // public Microsoft.EntityFrameworkCore.DbSet<Following> Followings { get; set; }
    }
}
