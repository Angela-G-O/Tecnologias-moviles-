using System;

using Xamarin.Forms;

namespace AngelaGomezOrtega
{
    public class Boton_1 : ContentPage
    {
        public Boton_1()
        {
            Content = new StackLayout
            {
                Children = {
                    new Label { Text = "Hello ContentPage" }
                }
            };
        }
    }
}


