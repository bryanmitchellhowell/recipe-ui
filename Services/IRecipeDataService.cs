using RecipeApp.Shared.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RecipeUi.Services
{
    public interface IRecipeDataService
    {
        Task<IEnumerable<Recipe>> GetAllRecipes();
        Task<IEnumerable<Recipe>> GetRecipes(int? RecipeId, string RecipeName);
        Task<bool> CreateRecipe(Recipe recipe);
        Task<bool> EditRecipe(int id, Recipe recipe);
        Task<Recipe> SingleRecipe(int id);
        Task<bool> DeleteRecipe(int id);
    }
}
