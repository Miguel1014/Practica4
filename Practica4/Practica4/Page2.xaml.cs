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
    public partial class Page2 : ContentPage
    {
        public Page2()
        {
            InitializeComponent();

        }

        public class datos1
        {

            public static Picker VCarrera1 = new Picker();
            public static Picker VSemestre1 = new Picker();
            public static Entry VMatricula1 = new Entry();





        }


        private void Button_Clicked(object sender, EventArgs e)
        {

            datos1.VCarrera1.SelectedItem = picker.SelectedItem;
            datos1.VSemestre1.SelectedItem = picker1.SelectedItem;
            datos1.VMatricula1.Text = VMatricula.Text;

            var Xcarrera = picker.SelectedItem;
            var Xsemestre = picker1.SelectedItem;
            var Xmatricula = VMatricula.Text;


            string scarrera = "" + picker.SelectedIndex;
            string ssemestre = "" + picker1.SelectedItem;
            var smatricula = VMatricula.Text;


            if (!string.IsNullOrEmpty(scarrera) && !string.IsNullOrEmpty(ssemestre) && !string.IsNullOrEmpty(smatricula))
            {

                Navigation.PushModalAsync(new Page3());
            }
            else
            {
                DisplayAlert("Error", "Te faltan datos por llenar", "Ok");

            }


        }
    }
}