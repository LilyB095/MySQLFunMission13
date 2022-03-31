using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MySQLFun.Models
{
    public class Recipe
    {
        //We are neither going to scaffold or do code first.
        //We are going to code based on what we see in the MySQL database
        //Hilton's dad would argue this is the "correct" way to do this :-)

        [Key]
        [Required]
        public  int RecipeID { get; set; }
        public string RecipeTitle { get; set; }
        public int RecipeClassID { get; set; }
        public string Preparation { get; set; }
        public string Notes { get; set; }

    }
}
