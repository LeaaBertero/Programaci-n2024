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
    public partial class Lista : Form
    {
        int posicion = 0;
        Persona[] Personas = new Persona[4];

        public Lista()
        {
            InitializeComponent();
        }

        private void btCargar_Click(object sender, EventArgs e)
        {
            Persona persona = new Persona();

            persona.Nombre = txNombre.Text;
            persona.Apellido = txApellido.Text;
            persona.Edad = Convert.ToInt32(txEdad.Text);

            txNombre.Text = "";
            txApellido.Text = "";
            txEdad.Text = "";

            Personas[posicion] = persona;
            posicion = posicion + 1;
        }

        private void btCerrar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btMostrar_Click(object sender, EventArgs e)
        {
            foreach (Persona persona in Personas)
            {
                lbLista.Visible = true;

                lbLista.Text = "Lista de personas: " + "\r\n" + "\r\n"
               + "Nombre: " + Personas[0].Nombre + "\r\n"
               + "Apellido: " + Personas[0].Apellido + "\r\n"
               + "Edad: " + Personas[0].Edad + "\r\n" + "\r\n"
               + "Nombre: " + Personas[1].Nombre + "\r\n"
               + "Apellido: " + Personas[1].Apellido + "\r\n"
               + "Edad: " + Personas[1].Edad + "\r\n" + "\r\n"
               + "Nombre: " + Personas[2].Nombre + "\r\n"
               + "Apellido: " + Personas[2].Apellido + "\r\n"
               + "Edad: " + Personas[2].Edad + "\r\n" + "\r\n"
               + "Nombre: " + Personas[3].Nombre + "\r\n"
               + "Apellido: " + Personas[3].Apellido + "\r\n"
               + "Edad: " + Personas[3].Edad;
            }
        }

        private void btBorrarlista_Click(object sender, EventArgs e)
        {
            lbLista.Text = string.Empty;
        }
    }
}
