using System;
using System.Windows.Forms;

namespace Calculadora
{
    public partial class Calculadora : Form
    {
        double valor1, valor2;
        string operacion;

        public Calculadora()
        {
            InitializeComponent();
        }

        private void NumeroUnoButton_Click_1(object sender, EventArgs e)
        {
            if (ResultadoTextBox.Text == string.Empty)
            {
                ResultadoTextBox.Text = "1";
            }
            else
            {
                ResultadoTextBox.Text += "1";
            }
        }

        private void NumeroDosButton_Click(object sender, EventArgs e)
        {
            if (ResultadoTextBox.Text == string.Empty)
            {
                ResultadoTextBox.Text = "2";
            }
            else
            {
                ResultadoTextBox.Text += "2";
            }
        }

        private void NumeroTresButton_Click(object sender, EventArgs e)
        {
            if (ResultadoTextBox.Text == "")
            {
                ResultadoTextBox.Text = "3";

            }
            else
            {
                ResultadoTextBox.Text = ResultadoTextBox.Text + "3";
            }

        }

        private void NumeroCuatroButton_Click(object sender, EventArgs e)
        {
            if (ResultadoTextBox.Text == "")
            {
                ResultadoTextBox.Text = "4";

            }
            else
            {
                ResultadoTextBox.Text = ResultadoTextBox.Text + "4";
            }

        }

        private void NumeroCincoButton_Click(object sender, EventArgs e)
        {
            if (ResultadoTextBox.Text == "")
            {
                ResultadoTextBox.Text = "5";

            }
            else
            {
                ResultadoTextBox.Text = ResultadoTextBox.Text + "5";
            }

        }

        private void NumeroSeisButton_Click(object sender, EventArgs e)
        {
            if (ResultadoTextBox.Text == "")
            {
                ResultadoTextBox.Text = "6";

            }
            else
            {
                ResultadoTextBox.Text = ResultadoTextBox.Text + "6";
            }

        }

        private void NumeroSieteButton_Click(object sender, EventArgs e)
        {
            if (ResultadoTextBox.Text == "")
            {
                ResultadoTextBox.Text = "7";

            }
            else
            {
                ResultadoTextBox.Text = ResultadoTextBox.Text + "7";
            }

        }

        private void NumeroOchoButton_Click(object sender, EventArgs e)
        {
            if (ResultadoTextBox.Text == "")
            {
                ResultadoTextBox.Text = "8";
            }
            else
            {
                ResultadoTextBox.Text = ResultadoTextBox.Text + "8";
            }
        }

        private void NumeroNueveButton_Click(object sender, EventArgs e)
        {
            if (ResultadoTextBox.Text == "")
            {
                ResultadoTextBox.Text = "9";
            }
            else
            {
                ResultadoTextBox.Text +=  "9";
            }
        }

        private void CeroButton_Click(object sender, EventArgs e)
        {
            if (ResultadoTextBox.Text == "")
            {
                ResultadoTextBox.Text = "0";
            }
            else
            {
                ResultadoTextBox.Text = ResultadoTextBox.Text + "0";
            }
        }

        private void LimpiarButton_Click(object sender, EventArgs e)
        {
            valor1 = 0;
            valor2 = 0;
            ResultadoTextBox.Clear();
            ResultadoTextBox.Focus();
        }

        private void DivididoButton_Click(object sender, EventArgs e)
        {
            valor1 = Convert.ToDouble(ResultadoTextBox.Text);
            operacion = "/";
            ResultadoTextBox.Clear();
            ResultadoTextBox.Focus();
        }

        private void PorButton_Click(object sender, EventArgs e)
        {
            valor1 = Convert.ToDouble(ResultadoTextBox.Text);
            operacion = "*";
            ResultadoTextBox.Clear();
            ResultadoTextBox.Focus();
        }

        private void MasButton_Click(object sender, EventArgs e)
        {
            valor1 = Convert.ToDouble(ResultadoTextBox.Text);
            operacion = "+";
            ResultadoTextBox.Clear();
            ResultadoTextBox.Focus();
        }

        private void MenosButton_Click(object sender, EventArgs e)
        {
            valor1 = Convert.ToDouble(ResultadoTextBox.Text);
            operacion = "-";
            ResultadoTextBox.Clear();
            ResultadoTextBox.Focus();
        }

        private void IgualButton_Click(object sender, EventArgs e)
        {
            valor2 = Convert.ToDouble(ResultadoTextBox.Text);
            switch (operacion)
            {
                case "+": ResultadoTextBox.Text = Convert.ToString(valor1 + valor2); break;
                case "-": ResultadoTextBox.Text = Convert.ToString(valor1 - valor2); break;
                case "*": ResultadoTextBox.Text = Convert.ToString(valor1 * valor2); break;
                case "/": ResultadoTextBox.Text = Convert.ToString(valor1 / valor2); break;
            }
        }

        private void PuntoButton_Click(object sender, EventArgs e)
        {
            if (ResultadoTextBox.Text == "")
            {
                ResultadoTextBox.Text = ".";
            }
            else
            {
                ResultadoTextBox.Text = ResultadoTextBox.Text + ".";
            }
        }
    }


}


