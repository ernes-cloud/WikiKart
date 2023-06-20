using System;
using System.Collections.Generic;

using Xamarin.Forms;
using WikiKart.ViewModels;

namespace WikiKart.Views.AccessApp
{
    public partial class RegisterPage : ContentPage
    {
        public RegisterPage()
        {
            InitializeComponent();
            BindingContext = new RegisterViewModel();
            NavigationPage.SetHasNavigationBar(this, false);

        }


        private async void NavToLogin_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new LoginPage());
        }
    }
}