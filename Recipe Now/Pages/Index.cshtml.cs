using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;
using Recipe_Now.Data; //might not need it here but for other pages
using Recipe_Now.Models; //same here

namespace Recipe_Now.Pages
{
    public class IndexModel : PageModel
    {
        
        private readonly ILogger<IndexModel> _logger;

        //model properties go here

        //constructor, need it for other pages to access database
        public IndexModel(ILogger<IndexModel> logger)
        {
            _logger = logger;//anything that uses the database might not be needed here but in other pages
            
        }

        public void OnGet(string searchString)
        {
            //CurrentFilter = searchString;
            //example
           //_dbContext.Users
        }

        //public void OnPost()
        //{
        //    CurrentFilter = (string)ViewData["SearchString"];
        //}
    }
}
