using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejercicios_Guia1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnsave_Click(object sender, EventArgs e)
        {
            string name  =  textBox1.Text;
            string mensaje = string.Format("Bienvenido al segundo formulario " + name);
            Form2 frmrecibe = new Form2(mensaje); /* creo un objeto del segundo formulario,
 adonde mando información*/
            frmrecibe.Visible = true; // muestra el nuevo formulario
            this.Visible = false; // esconde el formulario actual
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
