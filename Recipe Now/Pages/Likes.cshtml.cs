using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Recipe_Now.Data;
using Recipe_Now.Models;
using Microsoft.EntityFrameworkCore;

namespace Recipe_Now.Pages
{
    
    public class LikesModel : PageModel
    {
        readonly Recipe_NowContext _dbContext;
        public List<Like> Likes = new List<Like>();
        public Like Like = new Like();
         
        IdentityUser currentUser;
        public List<Recipe> FavoriteRecipes = new List<Recipe>();
        public LikesModel(Recipe_NowContext dbContext)
        {
            _dbContext = dbContext;
            
        }
        public void OnGet()
        {
            currentUser = _dbContext.Users.FirstOrDefault(x => x.Id == User.FindFirst(ClaimTypes.NameIdentifier).Value);
            //ClaimsPrincipal currentUser = this.User;
            //var currentUserID = currentUser.FindFirst(ClaimTypes.NameIdentifier);

            var likes = _dbContext.Likes
                .Where(l => l.User.Id == currentUser.Id);
            Likes = likes.ToList();
            if (!(Likes.Count() == 0))
            {
                List<int> rids = new List<int>();
                foreach (var l in Likes)
                    rids.Add(l.RecipeId);
                //foreach (var l in Likes)
                //{
                var recipes = _dbContext.Recipes
                        .Where(r => rids.Contains(r.RecipeId));
                FavoriteRecipes = recipes.ToList();
                //}
            }

        }

        public async Task<IActionResult> OnPostAsync()
        {
            currentUser = _dbContext.Users.FirstOrDefault(x => x.Id == User.FindFirst(ClaimTypes.NameIdentifier).Value);
            Like.RecipeId = int.Parse(Request.Form["newLike"]);
            Like.User = currentUser;
            
            _dbContext.Likes.Add(Like);
            await _dbContext.SaveChangesAsync();
            return RedirectToPage("./Card");
        }

        
    }
   
}
