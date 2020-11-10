using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Recipe_Now.Models
{
    public class Following
    {
     
        public string Follower { get; set; }
       
        public string Followed { get; set; }
    }
}
