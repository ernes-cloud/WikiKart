using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.PlatformConfiguration;
using Xamarin.Forms.PlatformConfiguration.AndroidSpecific;
using Xamarin.Forms.Xaml;

namespace WikiKart.Views.AccessApp
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Menu : Xamarin.Forms.TabbedPage
    {
        public Menu()
        {
            InitializeComponent();
            On<Android>().SetToolbarPlacement(ToolbarPlacement.Top);
            On<Android>().SetIsSmoothScrollEnabled(true);
            NavigationPage.SetHasNavigationBar(this, false);
        }
    }
}