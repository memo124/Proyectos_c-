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
    public partial class Form2 : Form
    {
        public Form2(string text)
        {
            InitializeComponent();
            brecibido.Text = text;
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void btnregreso_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1(); //instanciamos al primer formulario
            this.Close(); //cerramos el formulario actual
            form1.Visible = true;
        }
    }
}
