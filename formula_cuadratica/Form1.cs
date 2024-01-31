using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace formula_cuadratica
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            double a=0, b = 0, c = 0, x1 = 0, x2 = 0, discriminant = 0;
            a = double.Parse(txta.Text);
            b = double.Parse(txtb.Text);
            c = double.Parse(txtc.Text);
            discriminant = Math.Pow(b, 2) - 4 * a * c;
            x1 = (-b + Math.Sqrt(discriminant)) / (2 * a);
            x2 = (-b - Math.Sqrt(discriminant)) / (2 * a);
            txtx1.Text = x1.ToString();
            txtx2.Text = x2.ToString();
        }
    }
}
