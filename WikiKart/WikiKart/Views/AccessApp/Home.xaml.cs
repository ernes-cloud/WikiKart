using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace WikiKart.Views.AccessApp
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Home : ContentPage
    {
        public Home()
        {
            InitializeComponent();
        }
        async void LogOutButton(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new LoginPage
            {
                BindingContext = new LoginPage()
            });

        }
    }
}