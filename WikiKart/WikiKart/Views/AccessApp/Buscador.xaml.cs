using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using WikiKart.ModelsView;
using WikiKart.Models;

namespace WikiKart.Views.AccessApp
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Buscador : ContentPage
    {
        public Buscador()
        {

            InitializeComponent();

            BindingContext = new CircuitoModelo();
        }

        private async void OnItemSelected(Object sender, ItemTappedEventArgs e)
        {
            var mydetails = e.Item as ListaCircuitos;
            await Navigation.PushAsync(new DetalleCircuito(mydetails.Name, mydetails.Descripcion, mydetails.Image, mydetails.Trazado, mydetails.imagenTrazado, mydetails.Actividades, mydetails.imagenActividades, mydetails.FlotaKarts, mydetails.imagenFlotakarts, mydetails.Instalaciones, mydetails.imagenInstalaciones, mydetails.telefono, mydetails.email));
        }

        private void txtSearch_TextChanged(object sender, TextChangedEventArgs e)
        {
            var _container = BindingContext as CircuitoModelo;


            if (string.IsNullOrWhiteSpace(e.NewTextValue))
            {
                CircuitoListView.ItemsSource = _container.CircuitoList;
            }
            else
            {
                CircuitoListView.ItemsSource = _container.CircuitoList.Where(i => i.Name.Contains(e.NewTextValue));
            }

        }
    }
}