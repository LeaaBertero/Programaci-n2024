using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ListaPersonas
{
    public partial class FrmClave : Form
    {
        public FrmClave()
        {
            InitializeComponent();
        }

        private void btSalir_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btIngresar_Click(object sender, EventArgs e)
        {
            if (txIngresar.Text == "clave")
            {
                Form Lista = new Lista();
                Lista.ShowDialog();
            }
            else
            {
                MessageBox.Show("Clave no valida");
            }
        }
    }
}
