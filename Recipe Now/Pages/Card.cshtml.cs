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
    public class CardModel : PageModel
    {
        readonly Recipe_NowContext _dbContext;
        public List<Recipe> Recipes = new List<Recipe>();

        //public Tuple<Recipe, List<string>> RecipeIngredients = new Tuple<Recipe, List<string>>(Recipes[0], Ingredients);
        public CardModel(Recipe_NowContext dbContext)
        {
            
            _dbContext = dbContext;
        }
        public void OnGet()
        {
                var recipes = _dbContext.Recipes
                 .FromSqlRaw("Select * from Recipes where IsDrink = 0" );

            
            Recipes.AddRange(_dbContext.Recipes);
            Recipes = recipes.ToList();
            Recipes = RandomList.Randomize(Recipes).ToList();
            foreach (var r in Recipes)
            {
                var ingredients = _dbContext.Ingredients
                    .Where(i => i.RecipeId == r.RecipeId);
                r.Ingredients = ingredients.ToList();
            }
        }
    }
}
