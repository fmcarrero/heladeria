using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace heladeria
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            tipo_pago Tipo_pago = new tipo_pago(textBox1.Text, textBox2.Text, textBox3.Text);
            int resulado = tipo_pago_data.agregar(Tipo_pago);

            if (resulado > 0)
            {
                MessageBox.Show("datos guardados", "datos guardados", MessageBoxButtons.OK, MessageBoxIcon.Question);
            }
            else {
                MessageBox.Show("datos NO guardados", "datos NO guardados", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            buscar frm = new buscar();
            frm.Show();
        }
    }
}
