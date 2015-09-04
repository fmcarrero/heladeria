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
    public partial class Proveedor : Form
    {
       

        public Proveedor()
        {
            InitializeComponent();
            Screen screen = Screen.PrimaryScreen;
            int Height = screen.Bounds.Width;
            int Width = screen.Bounds.Height;

            this.Height = Width;
            this.Width = Height;
            backend.leerXml le = new backend.leerXml();
            String var = le.leer("nombre");
            label2.Text = var;
            label2.ForeColor = Color.Blue;

            backend.fecha fec = new backend.fecha();
            var fecha = fec.month_year();
            label4.Text = fecha;
            label4.ForeColor = Color.Blue;
            label6.ForeColor = Color.Blue;
            panel5.Width = Height;
            panel6.Width = Height;
            panel6.BackColor = Color.Green;
            label7.Font = new System.Drawing.Font(label1.Font, FontStyle.Bold);
            label8.Font = new System.Drawing.Font(label1.Font, FontStyle.Bold);
            comboBox1.DataSource = backend.proveedores_back.llenar_combo();
            dataGridView1.Height = this.Height - 220;
            //String clave=GUI.usuarios.Login.Obusuario.Clave;
          
        }

        private void toolStripMenuItem9_Click(object sender, EventArgs e)
        {
            GUI.usuarios.PUsuario user = new usuarios.PUsuario();
            this.Hide();
            user.ShowDialog();
            
            this.Close();
        }

        private void Proveedor_Activated(object sender, EventArgs e)
        {
            dataGridView1.DataSource = backend.proveedores_back.listarProveedores(comboBox1.Text, textBox1.Text);
            
            dataGridView1.Columns[3].HeaderText = "Categoria";
            
        }

        private void pictureBox2_MouseHover(object sender, EventArgs e)
        {
            this.Cursor = Cursors.Hand;
        }

        private void pictureBox2_MouseLeave(object sender, EventArgs e)
        {
            this.Cursor = Cursors.Default;
        }

        private void pictureBox1_MouseHover(object sender, EventArgs e)
        {
            this.Cursor = Cursors.Hand;
        }

        private void pictureBox1_MouseLeave(object sender, EventArgs e)
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

        private void pictureBox8_MouseHover(object sender, EventArgs e)
        {
            this.Cursor = Cursors.Hand;
        }

        private void pictureBox8_MouseLeave(object sender, EventArgs e)
        {
            this.Cursor = Cursors.Default;
        }

        private void pictureBox7_MouseHover(object sender, EventArgs e)
        {
            this.Cursor = Cursors.Hand;
        }

        private void pictureBox7_MouseLeave(object sender, EventArgs e)
        {
            this.Cursor = Cursors.Default;
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process calc = new System.Diagnostics.Process { StartInfo = { FileName = @"calc.exe" } };
            calc.Start();
        }

        private void comboBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }
        public void cambiador(KeyEventArgs e)
        {
            if (e.KeyData == (Keys.F5))
            {
                comboBox1.Text = "nit";

            }
            else if (e.KeyData == (Keys.F6))
            {
                comboBox1.Text = "nombre";
            }
            else if (e.KeyData == (Keys.F7))
            {
                comboBox1.Text = "direccion";
            }
            else if (e.KeyData == (Keys.F8))
            {
                comboBox1.Text = "correo";
            }
        }

        private void textBox1_KeyDown(object sender, KeyEventArgs e)
        {
            cambiador(e);
        }

        private void comboBox1_KeyDown(object sender, KeyEventArgs e)
        {
            cambiador(e);
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            
            dataGridView1.DataSource = backend.proveedores_back.listarProveedores(comboBox1.Text, textBox1.Text);

        }

        private void pictureBox4_MouseHover(object sender, EventArgs e)
        {
            this.Cursor = Cursors.Hand;
        }

        private void pictureBox4_MouseLeave(object sender, EventArgs e)
        {
            this.Cursor = Cursors.Default;
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {

                dataGridView1.DataSource = backend.proveedores_back.listarProveedores(comboBox1.Text, textBox1.Text);

            }
        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {
            var selectedCell = dataGridView1.SelectedCells[0];
            string var = Convert.ToString(selectedCell.Value);
            function(var);
        }
        public void function(String var)
        {

            DialogResult result = MessageBox.Show("desea eliminar al proveedor " + var, "Eliminar", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                //code for Yes

                int retur = backend.proveedores_back.elimiarProveedor(var);
                if (retur > 0)
                {
                    MessageBox.Show("se elimino correctamente ");
                }
                else
                {
                    MessageBox.Show("no se elimino correctamente ");
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

        private void dataGridView1_KeyDown(object sender, KeyEventArgs e)
        {
            var selectedCell = dataGridView1.SelectedCells[0];
            string var = Convert.ToString(selectedCell.Value);
            if (e.KeyCode == Keys.Delete)
            {
                function(var);
            }
        }

        private void pictureBox9_Click(object sender, EventArgs e)
        {
            addProveedor newProveedor = new addProveedor();
            newProveedor.ShowDialog();
        }
    }
    }

