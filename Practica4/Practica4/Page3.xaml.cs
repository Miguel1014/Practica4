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
    public partial class Page3 : ContentPage
    {
        public Page3()
        {
            InitializeComponent();
        }

        public class datos3
        {

            public static Entry VCorreo1 = new Entry();
            public static Entry VGithub1 = new Entry();



        }

        private void Button_Clicked(object sender, EventArgs e)
        {
            datos3.VCorreo1.Text = VCorreo.Text;
            datos3.VGithub1.Text = VGithub.Text;

            string scorreo = VCorreo.Text;
            string sgithub = VGithub.Text;



            if (!string.IsNullOrEmpty(scorreo) && !string.IsNullOrEmpty(sgithub))
            {

                Navigation.PushModalAsync(new Page4());
            }
            else
            {
                DisplayAlert("Error", "Te faltan datos por llenar", "Ok");

            }

        }
    }
}