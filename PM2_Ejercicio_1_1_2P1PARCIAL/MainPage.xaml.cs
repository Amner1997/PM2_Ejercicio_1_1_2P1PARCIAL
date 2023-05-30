using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace PM2_Ejercicio_1_1_2P1PARCIAL
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private void suma_Clicked(object sender, EventArgs e)
        {
            double numero1, numero2;
            if (double.TryParse(numero1Entry.Text, out numero1) && double.TryParse(numero2Entry.Text, out numero2))
            {
                Calculadora calculadora = new Calculadora();
                double resultado = calculadora.Sumar(numero1, numero2);
                Navigation.PushAsync(new SegundaPagina(resultado));
                Console.WriteLine(resultado);
            }
            else
            {
                
            }
        }

        private void resta_Clicked(object sender, EventArgs e)
        {
            double numero1, numero2;
            if (double.TryParse(numero1Entry.Text, out numero1) && double.TryParse(numero2Entry.Text, out numero2))
            {
                Calculadora calculadora = new Calculadora();
                double resultado = calculadora.Restar(numero1, numero2);
                Navigation.PushAsync(new SegundaPagina(resultado));
                Console.WriteLine(resultado);

            }
           
        }

        private void division_Clicked(object sender, EventArgs e)
        {
            double numero1, numero2;
            if (double.TryParse(numero1Entry.Text, out numero1) && double.TryParse(numero2Entry.Text, out numero2))
            {
                Calculadora calculadora = new Calculadora();
                double resultado = calculadora.Dividir(numero1, numero2);
                Navigation.PushAsync(new SegundaPagina(resultado));
                Console.WriteLine(resultado);
            }
            else
            {

            }
        }

        private void multiplicacion_Clicked(object sender, EventArgs e)
        {
            double numero1, numero2;
            if (double.TryParse(numero1Entry.Text, out numero1) && double.TryParse(numero2Entry.Text, out numero2))
            {
                Calculadora calculadora = new Calculadora();
                double resultado = calculadora.Multiplicar(numero1, numero2);
                Navigation.PushAsync(new SegundaPagina(resultado));
                Console.WriteLine(resultado);
            }
            else
            {

            }
        }
    }
}
