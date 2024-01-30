using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejercicio5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            listBox1.Items.Add(textBox1.Text);
            textBox1.Clear();
            textBox1.Focus();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int mayorneg = -1000;
            for (int i = 0; i < listBox1.Items.Count; i++)
            {
                string valor = listBox1.Items[i].ToString();
                int numero = int.Parse(valor);
                if (numero < 0 && numero % 2 == 0)
                {
                    if (numero > mayorneg)
                    {
                        mayorneg = numero;
                        textBox2.Text = mayorneg.ToString();
                    }
                }
                else
                {
                    textBox2.Text = "No hay números negativos pares";
                }
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            double cantidadnumeros = listBox1.Items.Count;
            double cantidadceros = 0;
            double porcentaje = 0;
            for (int i = 0; i < listBox1.Items.Count; i++)
            {
                string valor = listBox1.Items[i].ToString();
                int numero = int.Parse(valor);
                if (numero == 0)
                {
                    cantidadceros = cantidadceros + 1;
                }
            }
            porcentaje = (cantidadceros / cantidadnumeros) * 100;
            textBox3.Text = porcentaje.ToString() + "%";

        }

        private void button4_Click(object sender, EventArgs e)
        {
            double prom;
            double cantidadimpares = 0;
            double suma = 0;
            for (int i = 0; i < listBox1.Items.Count; i++)
            {
                string valor = listBox1.Items[i].ToString();
                int numero = int.Parse(valor);

               if (numero > 0 && numero % 2 != 0)
                {
                    suma = suma + numero;
                    cantidadimpares = cantidadimpares + 1;
                }
            }
            prom = suma / cantidadimpares;
            textBox4.Text = prom.ToString();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            int mayor = 0;
            for (int i = 0; i < listBox1.Items.Count; i++)
            {
                string valor = listBox1.Items[i].ToString();
                int numero = int.Parse(valor);
                if (numero > 0 && numero % 2 == 0)
                {
                    if (numero > mayor)
                        mayor = numero;
                }
            }
            textBox5.Text = mayor.ToString();
        }
    }
}
