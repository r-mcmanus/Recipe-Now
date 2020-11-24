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
        public List<string> Ingredients = new List<string>();

        //public Tuple<Recipe, List<string>> RecipeIngredients = new Tuple<Recipe, List<string>>(Recipes[0], Ingredients);
        public CardModel(Recipe_NowContext dbContext)
        {
            
            _dbContext = dbContext;
        }
        public void OnGet()
        {
            Recipes.AddRange(_dbContext.Recipes);
            //foreach (var recipe in Recipes)
            //{
            //    //recipe.Ingredients.TrimEnd(']');
            //    //recipe.Ingredients.Remove(recipe.Ingredients.Length - 1, 1);
            //    //Ingredients.Add(recipe.Ingredients.Split("', '"));
                
            //}
        }
    }
}
