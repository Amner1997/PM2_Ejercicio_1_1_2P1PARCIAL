using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace PM2_Ejercicio_1_1_2P1PARCIAL
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class SegundaPagina : ContentPage
    {
        public SegundaPagina(double resultado)
        {
            InitializeComponent();

            Label resultadoLabel = new Label
            {
                Text = $"El resultado es: {resultado}",
                FontSize = 30, 
                TextColor = Color.Red, 
                HorizontalTextAlignment = TextAlignment.Center, 
                VerticalTextAlignment = TextAlignment.Center, 
                Margin = new Thickness(10), 
                BackgroundColor = Color.LightGray
            };

            Content = new StackLayout
            {
                Children = { resultadoLabel }
            };
        }
    }
}