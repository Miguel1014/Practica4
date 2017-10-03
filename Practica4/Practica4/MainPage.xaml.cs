using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace Practica4
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private void E_calciuladora(object sender, EventArgs e)
        {

            Navigation.PushAsync(new Page1());

        }

        private void E_Formulario(object sender, EventArgs e)
        {

            Navigation.PushAsync(new Formulario());

        }

        

        private void E_Portada(object sender, EventArgs e)
        {

            Navigation.PushAsync(new Portada());

        }

    }
}
