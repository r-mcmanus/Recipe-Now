using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Recipe_Now.Models
{
    public class Recipe
    {
        [Key]
        public string Name  { get; set; }

        public string URL { get; set; }

        public string ImagePath { get; set; }

        public string Ingredients { get; set; } //= new List<string>();

        public bool IsDrink { get; set; }
    }
}
