using RecipeUi.Helpers;
using System;
using System.ComponentModel.DataAnnotations;

namespace RecipeUi.Pages
{
    public partial class Login
    {
        private class LoginModel
        {
            [Required]
            public string Username { get; set; }

            [Required]
            public string Password { get; set; }
        }

        private LoginModel model = new LoginModel();
        private bool loading;
        private string error;

        protected override void OnInitialized()
        {
            // redirect to home if already logged in
            if (AuthenticationService.User != null)
            {
                NavigationManager.NavigateTo("");
            }
        }

        private async void HandleValidSubmit()
        {
            loading = true;
            try
            {
                await AuthenticationService.Login(model.Username, model.Password);
                var returnUrl = NavigationManager.QueryString("returnUrl") ?? "";
                NavigationManager.NavigateTo(returnUrl);
            }
            catch (Exception ex)
            {
                error = ex.Message;
                loading = false;
                StateHasChanged();
            }
        }

       
    }
}
