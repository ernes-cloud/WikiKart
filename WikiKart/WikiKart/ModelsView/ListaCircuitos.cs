using System;
using System.Collections.Generic;
using System.Text;

namespace WikiKart.ModelsView
{
    class ListaCircuitos
    {
        //Datos de busqueda principales
        public string Name { get; set; }

        public bool Page { get; set; }
        public string Detail { get; set; }
        public string Image { get; set; }
        public string Descripcion { get; set; }

        //Resto de atos de pantalla detalles 
        public string Trazado { get; set; }
        public string imagenTrazado { get; set; }
        public string Actividades { get; set; }
        public string imagenActividades { get; set; }
        public string FlotaKarts { get; set; }
        public string imagenFlotakarts { get; set; }
        public string Instalaciones { get; set; }
        public string imagenInstalaciones { get; set; }
        public string telefono { get; set; }
        public string email { get; set; }
    }
}
