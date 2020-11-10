using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Recipe_Now.Models
{
    public class Recipe
    {
        public string Name  { get; set; }

        public string URL { get; set; }

        public string ImagePath { get; set; }

        public List<string> Ingredients { get; set; } = new List<string>();
    }
}
