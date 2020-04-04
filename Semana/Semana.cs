using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Semana
{
    public partial class Semana : Form
    {
        public Semana()
        {
            InitializeComponent();
        }

        private void LunesCheCkBox_CheckedChanged(object sender, EventArgs e)
        {
            if (LunesCheCkBox.Text == LunesCheCkBox.Text)
            {
                MessageBox.Show("Dia de trabajo");
            } 

            
        }

        private void MartesCheCkBox_CheckedChanged(object sender, EventArgs e)
        {
            if (MartesCheCkBox.Text == MartesCheCkBox.Text)
            {
                MessageBox.Show("siga trabajando mula");
            }
        }

        private void MiercolesCheCkBox_CheckedChanged(object sender, EventArgs e)
        {
            if (MartesCheCkBox.Text == MartesCheCkBox.Text)
            {
                MessageBox.Show("trabajar, trabajar");
            }
        }

        private void JuevesCheCkBoX_CheckedChanged(object sender, EventArgs e)
        {
            if (JuevesCheCkBoX.Text == JuevesCheCkBoX.Text)
            {
                MessageBox.Show("sigo trabajando");
            }
        }

        private void ViernesCheCkBox_CheckedChanged(object sender, EventArgs e)
        {
            if (ViernesCheCkBox.Text == ViernesCheCkBox.Text)
            {
                MessageBox.Show("es viernes y el cuerpo lo sabe");
            }
        }

        private void SabadoCheCkBox_CheckedChanged(object sender, EventArgs e)
        {
            if (SabadoCheCkBox.Text == SabadoCheCkBox.Text)
            {
                MessageBox.Show("dia de rumba");
            }
        }

        private void DomingoCheCkBox_CheckedChanged(object sender, EventArgs e)
        {
            if (DomingoCheCkBox.Text == DomingoCheCkBox.Text)
            {
                MessageBox.Show("dia de desenguayabe");
            }
        }
    }
}
