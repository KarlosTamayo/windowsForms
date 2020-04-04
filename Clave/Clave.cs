using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Clave
{
    public partial class Clave : Form
    {
        public Clave()
        {
            InitializeComponent();
        }

        private void ClaveCheckBox_CheckedChanged(object sender, EventArgs e)
        {          

            string clave = "123456";

            switch (clave)
            {
                case "123456":
                    MessageBox.Show("bien venido eres gandor");
                    break;

                default: MessageBox.Show("nladron"); break;
            }
        }

        private void ClaveDosCheCkBox_CheckedChanged(object sender, EventArgs e)
        {
            string clave = "123456";

            switch (clave)
            {
                case "1234":
                    MessageBox.Show("bien venido");
                    break;

                default: MessageBox.Show("nladron"); break;
            }

        }

        private void ClaveUnoCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            string clave = "123456";

            switch (clave)
            {
                case "1234":
                    MessageBox.Show("bien venido");
                    break;

                default: MessageBox.Show("nladron"); break;
            }
        }

        private void ClaveTresCheCkBox_CheckedChanged(object sender, EventArgs e)
        {
            string clave = "123456";

            switch (clave)
            {
                case "1234":
                    MessageBox.Show("bien venido");
                    break;

                default: MessageBox.Show("nladron"); break;
            }
        }
    }
    
}
