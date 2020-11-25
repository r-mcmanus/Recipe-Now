using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Recipe_Now.Data; 
using Recipe_Now.Models;

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
            Recipes.AddRange(_dbContext.Recipes);
           foreach (var r in Recipes)
            {
                var ingredients = _dbContext.Ingredients
                    .Where(i => i.RecipeId == r.RecipeId);
                r.Ingredients = ingredients.ToList();
            }
        }
    }
}
