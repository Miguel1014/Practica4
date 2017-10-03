using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Practica4
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Formulario : ContentPage
    {
        public Formulario()
        {

            InitializeComponent();


        }

        public class datos
        {

            public static Entry VNombre1 = new Entry();
            public static Entry VApellido1 = new Entry();
            public static Entry VTelefono1 = new Entry();
            public static Entry VDireccion1 = new Entry();




        }

        public void Button_Clicked(object sender, EventArgs e)
        {

            datos.VNombre1.Text = VNombre.Text;
            datos.VApellido1.Text = VApellido.Text;
            datos.VTelefono1.Text = VTelefono.Text;
            datos.VDireccion1.Text = VDireccion.Text;

            var Xnombre = VApellido.Text;
            var Xapellido = VApellido.Text;
            var Xtelefono = VTelefono.Text;
            var Xdireccion = VDireccion.Text;



            if (!string.IsNullOrEmpty(Xnombre) && !string.IsNullOrEmpty(Xapellido) && !string.IsNullOrEmpty(Xtelefono)
               && !string.IsNullOrEmpty(Xdireccion))
            {

                Navigation.PushModalAsync(new Practica4.Page2());
            }
            else
            {
                DisplayAlert("Error", "Te faltan datos por llenar", "Ok");

            }





        }
    }
}
