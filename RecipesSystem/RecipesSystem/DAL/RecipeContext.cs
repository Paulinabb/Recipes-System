using RecipesSystem.Models;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;

namespace RecipesSystem.DAL
{
    public class RecipeContext : DbContext
    {

        public RecipeContext() : base("RecipeContext")
        {
        }

        public DbSet<Chef> Chefs { get; set; }
        public DbSet<Recipe> Recipes { get; set; }
        

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
        }
    }
}