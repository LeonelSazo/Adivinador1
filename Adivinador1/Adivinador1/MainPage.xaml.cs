using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace Adivinador1
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private void Star_Clicked(object sender, EventArgs e)
        {
            lbl2.Text = "Piensa en un numero y ese numero multiplicalo por 2 ";
            Star.Text = "";
            sig1.Text = "Siguiente";
        }

        private void sig1_Clicked(object sender, EventArgs e)
        {
            lbl3.Text = "Al resultado de esa multiplicación sumale 8  ";
            sig2.Text = "Siguiente";

        }

        private void sig2_Clicked(object sender, EventArgs e)
        {
            lbl4.Text = "El resultado multiplicalo por 5";
            sig3.Text = "Siguiente";

        }

        private void sig3_Clicked(object sender, EventArgs e)
        {
            Calcular.Text = "Adivinar numero";
        }

        private void Calcular_Clicked(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(Resultd.Text))
            {
                var Num = int.Parse(Resultd.Text);
                var Result = (Num / 10) - 4;
                var res = Result.ToString();
                DisplayAlert("El numero en que pensaste es: ", res, "Ok");
                rein.Text = "Reiniciar";
            }
            else
            {
                DisplayAlert("Sin datos", "Llena el campo solicitado", "Continuar");
            }

        }

        private void rein_Clicked(object sender, EventArgs e)
        {
            lbl2.Text = " ";
            Star.Text = "Empezar";
            lbl3.Text = " ";
            sig1.Text = " ";
            lbl4.Text = " ";
            sig2.Text = " ";
            sig3.Text = " ";
            Calcular.Text = " ";
            rein.Text = " ";
            Resultd.Text = "";
        }
    }
}
