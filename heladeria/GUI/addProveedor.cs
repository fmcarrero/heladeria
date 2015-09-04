using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace heladeria.GUI
{
    public partial class addProveedor : Form
    {
        public static String com1 = "";
        public addProveedor()
        {
            InitializeComponent();
            
            backend.leerXml le = new backend.leerXml();
            String var = le.leer("nombre");
            label2.Text = var;
            label2.ForeColor = Color.Blue;
            backend.fecha fec = new backend.fecha();
            var fecha = fec.month_year();
            label4.Text = fecha;
            label4.ForeColor = Color.Blue;
            label6.ForeColor = Color.Blue;
            label6.Text = "USUARIOS";
            this.MaximizeBox = false;
            this.AutoSize = true;
            this.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            CenterToScreen();
            this.panel6.BackColor = Color.LightBlue;
            comboBox1.DataSource = backend.proveedores_back.llenar_combo_categoria();
            
        }
        public void sendData(String data)
        {
            backend.VO.proveedor proveedorOb = backend.proveedores_back.updateProveedor(data);
           
            textBox1.Text = proveedorOb.Nit;
            textBox2.Text = proveedorOb.Nombre;
            textBox3.Text = Convert.ToString( proveedorOb.Telefono);
            textBox4.Text= Convert.ToString(proveedorOb.Celular);
            textBox5.Text = Convert.ToString(proveedorOb.Fax);
            richTextBox1.Text = proveedorOb.Descripcion;
            textBox6.Text = proveedorOb.Direccion;
            textBox7.Text = proveedorOb.Correo;
            comboBox1.Text = proveedorOb.Codigo;
            com1 = "yes";
            this.Text = "Modificar proveedor";
            

        }
        private void richTextBox1_GotFocus(object sender, EventArgs e)
        {
            MessageBox.Show("hello");
        }

        private void richTextBox1_LostFocus(object sender, EventArgs e)
        {
            var tbox = sender as RichTextBox;
            if (tbox.Text == "")
            {
                tbox.Text = tbox.Name;
            }
        }

        private void addProveedor_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape) {
                this.Close();
            }
        }

       

        private void richTextBox1_Enter(object sender, EventArgs e)
        {
            if (richTextBox1.Text == "Descripcion")
            {
                richTextBox1.Text = "";
    }

        }

        private void richTextBox1_Leave(object sender, EventArgs e)
        {
            if (richTextBox1.Text == "")
            {
                richTextBox1.Text = "Descripcion";
             }
        }

        private void richTextBox1_MouseHover(object sender, EventArgs e)
        {
            ToolTip tt = new ToolTip();
            tt.SetToolTip(this.richTextBox1, "Descripcion");

        }

        private void pictureBox7_MouseHover(object sender, EventArgs e)
        {
            this.Cursor = Cursors.Hand;
        }

        private void pictureBox7_MouseLeave(object sender, EventArgs e)
        {
            this.Cursor = Cursors.Default;
        }

        private void pictureBox8_MouseHover(object sender, EventArgs e)
        {
            this.Cursor = Cursors.Hand;
        }

        private void pictureBox8_MouseLeave(object sender, EventArgs e)
        {
            this.Cursor = Cursors.Default;
        }

        private void pictureBox9_MouseHover(object sender, EventArgs e)
        {
            this.Cursor = Cursors.Hand;
        }

        private void pictureBox9_MouseLeave(object sender, EventArgs e)
        {
            this.Cursor = Cursors.Default;
        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {
            textBox1.Text = null;
            textBox2.Text = null;
            textBox3.Text = null;
            textBox4.Text = null;
            textBox5.Text = null;
            textBox6.Text = null;
            textBox7.Text = null;
            richTextBox1.Text = "Descripcion";
        }

        private void pictureBox8_Click(object sender, EventArgs e)
        {
            String mensaje = "";
            String mensaje2 = "";
            if (com1.Equals("yes")) {
                mensaje = "desea modificar al proveedor ";
                mensaje2 = "Modificar";
            }
            else{
                mensaje = "desea agregar al proveedor ";
                mensaje2 = "Agregar";
            }
            DialogResult result = MessageBox.Show(mensaje + textBox2.Text, mensaje2, MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);
            try {
                if (result == DialogResult.Yes)
                {
                    //code for Yes

                    backend.VO.proveedor objeProveedor = new backend.VO.proveedor(Convert.ToDecimal(textBox4.Text), backend.proveedores_back.obtenerCodigoCatProveedor(comboBox1.Text), textBox7.Text, richTextBox1.Text, textBox6.Text, Convert.ToInt16(textBox5.Text), textBox1.Text, textBox2.Text, Convert.ToInt32(textBox3.Text));
                    int resul = backend.proveedores_back.agregarProveedor(objeProveedor, com1);
                    if (resul > 0)
                    {
                        MessageBox.Show("guardado correctamente");
                       if (!com1.Equals("yes")) {
                            pictureBox7_Click(sender, e);
                        }
                        com1 = "no";
                       

                    }
                    else {
                        MessageBox.Show("NO guardado correctamente");
                    }


                }
                else if (result == DialogResult.No)
                {
                    //code for No
                }
                else if (result == DialogResult.Cancel)
                {
                    //code for Cancel
                }
            }
            catch (Exception ex) {
                MessageBox.Show("ocurrieron errores durante el proceso"+ex.ToString());
            }
        }

        private void textBox3_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsDigit(e.KeyChar))
            {
                e.Handled = false;
            }
            else
      if (Char.IsControl(e.KeyChar)) //permitir teclas de control como retroceso 
            {
                e.Handled = false;
            }
            else
            {
                //el resto de teclas pulsadas se desactivan 
                e.Handled = true;
            }
        }

        private void textBox4_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsDigit(e.KeyChar))
            {
                e.Handled = false;
            }
            else
      if (Char.IsControl(e.KeyChar)) //permitir teclas de control como retroceso 
            {
                e.Handled = false;
            }
            else
            {
                //el resto de teclas pulsadas se desactivan 
                e.Handled = true;
            }
        }

        private void textBox5_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsDigit(e.KeyChar))
            {
                e.Handled = false;
            }
            else
      if (Char.IsControl(e.KeyChar)) //permitir teclas de control como retroceso 
            {
                e.Handled = false;
            }
            else
            {
                //el resto de teclas pulsadas se desactivan 
                e.Handled = true;
            }
        }
    }
}
