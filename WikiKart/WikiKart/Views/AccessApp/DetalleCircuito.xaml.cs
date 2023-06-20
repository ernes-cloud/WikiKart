using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WikiKart.Database;
using WikiKart.Models;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace WikiKart.Views.AccessApp
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class DetalleCircuito : ContentPage
    {
        public DetalleCircuito()
        {
            InitializeComponent();
        }


        async void OnNoteAddedClicked2(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new NotePage
            {
                BindingContext = new Note()
            });

        }

        public DetalleCircuito(string Name,string Descripcion, string source, string Trazado, string imagenTrazado, string Actividades, string imagenActividades, string FlotaKarts, string imagenFlotakarts, string Instalaciones, string imagenInstalaciones, string telefono, string email)
        {
            InitializeComponent();

            //Datos principales de pantalla
            MyItemNameShow.Text = Name;
            MyCircuitoItemShow.Text = Descripcion;
            MyImageCall.Source = new UriImageSource()
            {
                Uri = new Uri(source)
            };

            //Resto de datos de pantalla
            TrazadoItem.Text = Trazado;
            imagenTrazadoItem.Source = new UriImageSource()
            {
                Uri = new Uri(imagenTrazado)
            };
            ActividadesItem.Text = Actividades;
            imagenActividadesItem.Source = new UriImageSource()
            {
                Uri = new Uri(imagenActividades)
            };
            FlotaKartsItem.Text = FlotaKarts;
            imagenFlotaKartsItem.Source = new UriImageSource()
            {
                Uri = new Uri(imagenFlotakarts)
            };
            InstalacionesItem.Text = Instalaciones;
            imagenInstalacionesItem.Source = new UriImageSource()
            {
                Uri = new Uri(imagenInstalaciones)
            };
            telefonoItem.Text = telefono;
            emailItem.Text = email;
        }
    }
}