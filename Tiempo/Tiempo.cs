using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tiempo
{
    public partial class Tiempo : Form
    {
        public Tiempo()
        {
            InitializeComponent();
        }

        private void Tiempo_Load(object sender, EventArgs e)
        {

        }

        private void CalcularButton_Click(object sender, EventArgs e)
        {
            double Velocidad, distancia, tiempo;

            distancia = Convert.ToDouble( DistanciaTextBox.Text) ;
            tiempo = Convert.ToDouble( TiempoTextBox.Text);

            //velocidad = distancia / tiempo

            Velocidad = distancia / tiempo;

            VelosidadTextBox.Text = Velocidad.ToString();
        }

    
    }
}
