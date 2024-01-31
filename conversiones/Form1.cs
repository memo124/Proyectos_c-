using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace conversiones
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Calcular_Click(object sender, EventArgs e)
        {
            double farenheit =0,celcius = double.Parse(txttemp.Text);
            farenheit = (celcius * 1.8) + 32;
            double pies =0,metro = double.Parse(txtlon.Text);
            pies = metro * 3.28;
            double libras = 0, kilogramos = double.Parse(txtpes.Text);
            libras = kilogramos * 2.2046;
            label4.Text = "celcius a farenheit: "+farenheit.ToString();
            label5.Text = "metros a pies: "+pies.ToString();
            label6.Text = "kilogramos a libras: "+libras.ToString();

        }
    }
}
