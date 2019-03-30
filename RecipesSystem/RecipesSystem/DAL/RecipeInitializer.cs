using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using RecipesSystem.Models;

namespace RecipesSystem.DAL
{
    public class RecipeInitializer : System.Data.Entity.DropCreateDatabaseIfModelChanges<RecipeContext>
    {
        protected override void Seed(RecipeContext context)
        {
            var chefs = new List<Chef>
            {
            new Chef{FirstName="Gordon", LastName="Ramsay",},
            new Chef{FirstName="Bobby", LastName="Flay"},
            new Chef{FirstName="Jamie", LastName="Olivier"},
            new Chef{FirstName="Action", LastName="Bronson"},
            new Chef{FirstName="Wolfgang", LastName="Puck"},
            new Chef{FirstName="Rachael", LastName="Ray"},
            };

            chefs.ForEach(s => context.Chefs.Add(s));
            context.SaveChanges();


            var recipes = new List<Recipe>
            {
            new Recipe{RecipeID=1,Title="Some recipe 1", Content="Do this, do that, add this, add that...", ChefID=1,},
            new Recipe{RecipeID=2,Title="Some recipe 2", Content="Do this, do that, add this, add that...", ChefID=1,},
            new Recipe{RecipeID=3,Title="Some recipe 3", Content="Do this, do that, add this, add that...", ChefID=2,},
            new Recipe{RecipeID=4,Title="Some recipe 4", Content="Do this, do that, add this, add that...", ChefID=3,},
            new Recipe{RecipeID=5,Title="Some recipe 5", Content="Do this, do that, add this, add that...", ChefID=3,},
            new Recipe{RecipeID=6,Title="Some recipe 6", Content="Do this, do that, add this, add that...", ChefID=3,},
            new Recipe{RecipeID=7,Title="Some recipe 7", Content="Do this, do that, add this, add that...", ChefID=4,},
            new Recipe{RecipeID=8,Title="Some recipe 8", Content="Do this, do that, add this, add that...", ChefID=4,},
            new Recipe{RecipeID=9,Title="Some recipe 9", Content="Do this, do that, add this, add that...", ChefID=5,},
            new Recipe{RecipeID=10,Title="Some recipe 10", Content="Do this, do that, add this, add that...", ChefID=6,},
            new Recipe{RecipeID=11,Title="Some recipe 11", Content="Do this, do that, add this, add that...", ChefID=6,},
            new Recipe{RecipeID=12,Title="Some recipe 12", Content="Do this, do that, add this, add that...", ChefID=6,},

            };
            recipes.ForEach(s => context.Recipes.Add(s));
            context.SaveChanges();

        }
    }
}