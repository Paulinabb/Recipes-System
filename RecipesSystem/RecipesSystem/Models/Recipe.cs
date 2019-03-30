using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace RecipesSystem.Models
{
    public class Recipe
    {
        [DatabaseGenerated(DatabaseGeneratedOption.None)]

        public int RecipeID { get; set; }
        public string Title { get; set; }
        public string Content { get; set; }

        public int ChefID { get; set; }
        public virtual Chef Chef { get; set; }

    }
}