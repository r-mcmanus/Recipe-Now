using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Recipe_Now.Data;
using Recipe_Now.Models;
using Recipe_Now.CSScripts;

namespace Recipe_Now.Pages
{
    public class SearchModel : PageModel
    {
        readonly Recipe_NowContext _dbContext;
        public List<Recipe> Recipes = new List<Recipe>();

        public SearchModel(Recipe_NowContext dbContext)
        {
            _dbContext = dbContext;
        }

        
        public async Task<IActionResult> OnPostAsync()
        {
            string searchString = Request.Form["searchString"];
            if (searchString == "")
            {
                Response.Redirect("Index");
                return Page();
            }

            if (searchString == "likes")
            {
                var recipe = _dbContext.Recipes
                    .FromSqlRaw("Select * from Recipes where NumberOfLikes != 0");
                    Recipes.AddRange(_dbContext.Recipes);

            foreach (var r in Recipes)
            {
                var ingredients = _dbContext.Ingredients
                    .Where(i => i.RecipeId == r.RecipeId);
                r.Ingredients = ingredients.ToList();
            }

            Recipes = recipe.ToList();
            return Page();
            }

            string ingQueryString = null;
            bool first = true;
            searchString.Trim();
            List<string> searchStringList =
                searchString.Split(new char[0],
                StringSplitOptions.RemoveEmptyEntries).ToList();
            foreach (var i in searchStringList)
            {
                if (first)
                {
                    ingQueryString += " Description LIKE '%" + i + "%'";
                    first = false;
                }
                else
                    ingQueryString += " AND Description LIKE '%" + i + "%'";
            }
            //var recipeIds =  _dbContext.Ingredients.
            //    FromSqlRaw("Select RecipeId from Ingredients where"
            //        + ingQueryString);
            var recipes = _dbContext.Recipes
                .FromSqlRaw("Select * from Recipes where RecipeId in " +
                "(Select RecipeId from Ingredients where" + ingQueryString +
                /*+ recipeIds +*/ ")");

                Recipes.AddRange(_dbContext.Recipes);
           foreach (var r in Recipes)
            {
                var ingredients = _dbContext.Ingredients
                    .Where(i => i.RecipeId == r.RecipeId);
                r.Ingredients = ingredients.ToList();
            }
                
            Recipes = recipes.ToList();
            Recipes = RandomList.Randomize(Recipes).ToList();
            if (Recipes == null)
            {
                return NotFound();
            }
            return Page();
        }
    }
}
