using System;
using System.Collections.Generic;

using Xamarin.Forms;
using WikiKart.ViewModels;

namespace WikiKart.Views.AccessApp
{
    public partial class LoginPage : ContentPage
    {
        public LoginPage()
        {
            InitializeComponent();
            BindingContext = new LoginViewModel();
            NavigationPage.SetHasNavigationBar(this, false);
        }


        private async void SignUp_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new RegisterPage());
        }

    }
}