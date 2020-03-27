using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NotasPromedio
{
    public partial class Promedio : Form
    {
        public Promedio()
        {
            InitializeComponent();
        }

        private void PromedioButton_Click(object sender, EventArgs e)
        {
            int notaUno = Convert.ToInt32(NotaUnoTextBox.Text);
            int notados = Convert.ToInt32(NotaDosTextBox.Text);
            int notatres = Convert.ToInt32(NotaTresTextBox.Text);
            int notacuatro = Convert.ToInt32(NotaCuatroTextBox.Text);
            int notacinco = Convert.ToInt32(NotaCincoTextBox.Text);

            const int contante = 5;

            int promedioo =  (notaUno + notados + notatres + notacuatro + notacinco ) / contante;

            PromedioTextBox.Text = promedioo.ToString();
            

        }

   
    }
}
