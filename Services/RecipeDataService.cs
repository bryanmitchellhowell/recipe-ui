using RecipeApp.Shared.Models;
using System.Net.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Net.Http.Json;

namespace RecipeUi.Services
{
    public class RecipeDataService : IRecipeDataService
    {
        private readonly HttpClient _httpClient;

        public RecipeDataService(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }

        public async Task<IEnumerable<Recipe>> GetAllRecipes()
        {
            return await _httpClient.GetFromJsonAsync<IEnumerable<Recipe>>($"/recipe/all");
        }

        public async Task<IEnumerable<Recipe>> GetRecipes(int? RecipeId, string RecipeName)
        {
            return await _httpClient.GetFromJsonAsync<IEnumerable<Recipe>>($"api/recipe/getAllRecipes");
        }
        public async Task<bool> CreateRecipe(Recipe recipe)
        {
            return await _httpClient.GetFromJsonAsync<bool>($"api/recipe/getAllRecipes");
        }
        public async Task<bool> EditRecipe(int id, Recipe recipe)
        {
            return await _httpClient.GetFromJsonAsync<bool>($"api/recipe/getAllRecipes");
        }
        public async Task<Recipe> SingleRecipe(int id)
        {
            return await _httpClient.GetFromJsonAsync<Recipe>($"api/recipe/getAllRecipes");
        }
        public async Task<bool> DeleteRecipe(int id)
        {
            return await _httpClient.GetFromJsonAsync<bool>($"api/recipe/getAllRecipes");
        }

    }
}
