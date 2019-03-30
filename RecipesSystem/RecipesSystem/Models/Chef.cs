using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace RecipesSystem.Models
{
    public class Chef
    {
        public int ChefID { get; set; }
        public string FirstName { get; set; }
        public string  LastName { get; set; }

        public virtual ICollection<Recipe> Recipes { get; set; }
    }
}