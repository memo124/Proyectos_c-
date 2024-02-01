using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace optimizacion_ejercicio5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            listBox1.Items.Add(textBox1.Text);
            textBox1.Clear();
            textBox1.Focus();
            textBox2.Text = retornoParesNegativos();
            textBox3.Text = retornoPromedioCero();
            textBox4.Text = retornoimParesPositivos();
            textBox5.Text = retornoMayorParesPositivos();
        }

        public string retornoParesNegativos()
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
                        return mayorneg.ToString();
                    }
                }
                else
                {
                    return "No hay números negativos pares";
                }
            }
            return "";
        }

        public string retornoPromedioCero()
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
            return porcentaje.ToString() + "%";
        }

        public string retornoimParesPositivos()
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
            return prom.ToString();
        }

        public string retornoMayorParesPositivos()
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
            return mayor.ToString();
        }
    }
}
