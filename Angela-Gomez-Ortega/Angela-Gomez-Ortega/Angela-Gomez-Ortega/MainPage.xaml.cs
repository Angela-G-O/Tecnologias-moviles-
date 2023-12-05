using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;


namespace Angela_Gomez_Ortega
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        async void Button_Clicked(System.Object sender, System.EventArgs e)
        {
            await Navigation.PushAsync(new Boton_1());  
        }

        async void Button_Clicked_1(System.Object sender, System.EventArgs e)
        {
            await Navigation.PushAsync(Boton_2());
        }

        async void Button_Clicked_2(System.Object sender, System.EventArgs e)
        {
            await Navigation.PopToRootAsync();
        }

        void Button_Clicked_3(System.Object sender, System.EventArgs e)
        {
        }
    }
}

