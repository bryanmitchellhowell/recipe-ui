using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Components;
using RecipeApp.Shared.Models;
using RecipeUi.Services;

namespace RecipeUi.Components.Recipe
{
    public partial class RecipeList
    {
        [Inject]
        public IRecipeDataService RecipeDataService { get; set; }

        //public RecipeDataService RecipeDataService { get; set; }

        IEnumerable<RecipeApp.Shared.Models.Recipe> Recipes { get; set; } 

        protected override async Task OnInitializedAsync()
        {
            Recipes = await RecipeDataService.GetAllRecipes();
        }

    }
}
