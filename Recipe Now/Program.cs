using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using Recipe_Now.Models;

namespace Recipe_Now
{
    public class Program
    {
        public static void Main(string[] args)
        {

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
            //    //string ingredients = recipeFile[i + 4].Remove(0, 2);                       
            //    //recipe.Ingredients = ingredients.Split("', '").ToList();           
            //    recipes.Add(recipe);
            //    i = i + 6;
            //}


            CreateHostBuilder(args).Build().Run();
        }

        public static IHostBuilder CreateHostBuilder(string[] args) =>
            Host.CreateDefaultBuilder(args)
                .ConfigureWebHostDefaults(webBuilder =>
                {
                    webBuilder.UseStartup<Startup>();
                });
    }
}
