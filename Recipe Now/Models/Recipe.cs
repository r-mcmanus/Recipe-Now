using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Recipe_Now.Models
{
    public class Recipe
    {
        [Key]
        public int RecipeId { get; set; }
        public string Name  { get; set; }

        public string URL { get; set; }

        public string ImagePath { get; set; }

        public List<Ingredient> Ingredients { get; set; } = new List<Ingredient>();

        public bool IsDrink { get; set; }

        public int NumberOfLikes { get; set; }


    }
}
