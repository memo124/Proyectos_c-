using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejercicio2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            //agrega item al comboBox
            cmbop.Items.Clear();
            cmbop.Items.Add("sumar");
            cmbop.Items.Add("Restar");
            //agrega item a la lista 
            lsadvance.Items.Clear();
            lsadvance.Items.Add
            ("Multiplicacion");
            lsadvance.Items.Add("Division");
            lsadvance.TabIndex = 0; 
            //habilita  por defecto la primera opción
            //inhabilita el combo y la lista 
            cmbop.Enabled = false;
            lsadvance.Enabled = false;

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton1.Checked == true)
            {
                cmbop.Enabled = true;
                lsadvance.Enabled = false;
            }
        }

        private void calcular_Click(object sender, EventArgs e)
        {
            double n1, n2, r;
            n1 = Convert.ToDouble(txtnumber1.Text);
            n2 = Convert.ToDouble(txtnumber2.Text);
            if (cmbop.Enabled == true)
            {
                if (cmbop.SelectedItem.ToString() == "sumar")
                    r = n1 + n2;
                else
                    r = n1 - n2;

                MessageBox.Show("El Resultado es " + r.ToString(), "Respuesta");
            }
            if (lsadvance.Enabled == true)
            {
                if (lsadvance.SelectedItem.ToString() == "Multiplicacion")
                    r = n1 * n2;
                else
                    r = n1 / n2;
                MessageBox.Show("El Resultado es " + r.ToString(), "Respuesta");
            }
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            cmbop.Enabled = false;
            lsadvance.Enabled = true;
            //me permite seleccionar el primer elemento de la lista 
            lsadvance.SelectedIndex = 0;
        }
    }
}
