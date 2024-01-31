using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace salario_empleado
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void txtdesc_TextChanged(object sender, EventArgs e)
        {

        }

        private void btncalcular_Click(object sender, EventArgs e)
        {
            double bruto = double.Parse(txtbruto.Text);
            double desc=0;
            double neto=0;
            if (rbg.Checked == true)
            {
                rgsg.Checked = false;
                rbs.Checked = false;
                desc = bruto * 0.20;
                neto = bruto - desc;
            }
            if (rgsg.Checked == true)
            {
                rbg.Checked = false;
                rbs.Checked = false;
                desc = bruto * 0.15;
                neto = bruto - desc;
            }
            if (rbs.Checked == true)
            {
                rbg.Checked = false;
                rgsg.Checked= false;
                desc = bruto * 0.05;
                neto = bruto - desc;
            }
            txtdesc.Text = desc.ToString();
            txtneto.Text = neto.ToString();

        }
    }
}
