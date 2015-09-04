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
    public partial class buscar : Form
    {
        public buscar()
        {
            InitializeComponent();
           
            comboBox1.Text = "codigo";
            this.ActiveControl = textBox1;
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = tipo_pago_data.BuscarTipoPago(comboBox1.Text,textBox1.Text);
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
           
            if (e.KeyChar == Convert.ToChar(Keys.Enter)){
                dataGridView1.DataSource = tipo_pago_data.BuscarTipoPago(comboBox1.Text, textBox1.Text);
                textBox1.SelectAll();
            }
        }

        private void comboBox1_KeyDown(object sender, KeyEventArgs e)
        {
            cambiador(e);
        }

        public void cambiador(KeyEventArgs e) {
            if (e.KeyData == (Keys.F5))
            {
                comboBox1.Text = "codigo";

            }
            else if (e.KeyData == (Keys.F6))
            {
                comboBox1.Text = "nombre";
            }
            else if (e.KeyData == (Keys.F7))
            {
                comboBox1.Text = "descripcion";
            }
        }
        private void textBox1_KeyDown(object sender, KeyEventArgs e)
        {
            cambiador(e);
        }

        private void comboBox1_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void comboBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
