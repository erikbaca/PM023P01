using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace PM023P01
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        // EVENTO ASINCRONO
        private async void btnmostrar_Clicked(object sender, EventArgs e)
        {
            await DisplayAlert("Datos", "El dato mostrado es " + txtnombre.Text, "OK");
        }

        private async void btnsegunda_Clicked(object sender, EventArgs e)
        {
            // Pasar la informacion de los label
            var emple = new Models.Empleado { id = 1, nombre = txtnombre.Text, apellido = txtapellidos.Text };

            var pagetwo = new Views.PageTwo();
            pagetwo.BindingContext = emple;
            await Navigation.PushAsync(pagetwo);
        }

        protected override void OnAppearing()
        {
            base.OnAppearing();
        }
    }
}
