using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace ExamenDiseño_JEVB
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private void Sumar(object sender, EventArgs e)
        {
            var num1 = double.Parse(Numeroo1.Text);
            var num2 = double.Parse(Numeroo2.Text);
            var resultado = num1 + num2;
            Resultadoo.Text = resultado.ToString();


        }

        private void Restar(object sender, EventArgs e)
        {
            var num1 = double.Parse(Numeroo1.Text);
            var num2 = double.Parse(Numeroo2.Text);
            var resultado = num1 - num2;
            Resultadoo.Text = resultado.ToString();

        }

        private void Dividir(object sender, EventArgs e)
        {
            var num1 = double.Parse(Numeroo1.Text);
            var num2 = double.Parse(Numeroo2.Text);
            var resultado = num1 / num2;
            Resultadoo.Text = resultado.ToString();
        }

        private void Multiplicar(object sender, EventArgs e)
        {
            var num1 = double.Parse(Numeroo1.Text);
            var num2 = double.Parse(Numeroo2.Text);
            var resultado = num1 * num2;
            Resultadoo.Text = resultado.ToString();
        }
    }
}
