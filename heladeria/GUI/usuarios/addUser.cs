using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace heladeria.GUI.usuarios
{
    public partial class addUser : Form
    {
        public static String com1 = "";
        public addUser()
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
            comboBox1.DataSource = backend.usuarios.usuarios_back.llenar_combo_idPermiso();
            textBox2.PasswordChar = '*';
            if (com1.Equals(""))
                linkLabel1.Visible = false;
            pictureBox9.Visible = false;
            
           
           
           
        }

        private void addUser_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {
            if (e.KeyCode == Keys.Escape) {
                this.Close();
                linkLabel1.Visible = false;

            }
            
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process calc = new System.Diagnostics.Process { StartInfo = { FileName = @"calc.exe" } };
            calc.Start();
        }

        private void comboBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
            if (e.KeyChar == Convert.ToChar(Keys.Escape))
            {
                this.Close();
                linkLabel1.Visible = false;

            }

        }

        private void pictureBox8_MouseHover(object sender, EventArgs e)
        {
            this.Cursor = Cursors.Hand;
            ToolTip tt = new ToolTip();
            tt.SetToolTip(this.pictureBox8, "Guardar");

        }

        private void pictureBox8_MouseLeave(object sender, EventArgs e)
        {
            this.Cursor = Cursors.Default;
        }

        private void pictureBox8_Click(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(textBox1.Text) && !String.IsNullOrEmpty(textBox2.Text))
            {


                int f = backend.usuarios.usuarios_back.agregarUser(textBox1.Text.Trim(), textBox2.Text.Trim(), richTextBox1.Text.Trim(), comboBox1.Text.Trim(), com1);
                if (f > 0)
                {
                    MessageBox.Show("correctamente guard");
                    textBox1.Text = null;
                    textBox2.Text = null;
                    richTextBox1.Text = null;
                    com1 = "no";


                }
                else
                {

                }
            }
            else {
                MessageBox.Show("campos vacios", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        public  void prueba(String data) {
           backend.VO.usuario user= backend.usuarios.usuarios_back.updateUser(data);
           
            textBox1.Text = user.Usuario;
            textBox2.Text = user.Clave;
            richTextBox1.Text = user.Descripcion;
            comboBox1.Text = user.Id_Permiso;
            com1 = "yes";
            linkLabel1.Visible = true;

        }
        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter) && textBox1.TextLength>0)
            {
                textBox2.Focus();
            }

            if (e.KeyChar == Convert.ToChar(Keys.Escape) )
            {
                this.Close();
                linkLabel1.Visible = false;
            }

        }

        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter) && textBox2.TextLength > 0)
            {
                richTextBox1.Focus();
            }
            if (e.KeyChar == Convert.ToChar(Keys.Escape))
            {
                this.Close();
                linkLabel1.Visible = false;
            }
        }

        private void richTextBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter) && richTextBox1.TextLength> 1)
            {
                comboBox1.Focus();
                linkLabel1.Visible = false;
            }
            if (e.KeyChar == Convert.ToChar(Keys.Escape))
            {
                this.Close();
                linkLabel1.Visible = false;
            }
        }

        private void addUser_Activated(object sender, EventArgs e)
        {

        }

        private void addUser_Load(object sender, EventArgs e)
        {
           // textBox2.Text = com1;
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

            textBox2.PasswordChar = '\0';
            if (linkLabel1.Text.Equals("ver clave"))
            {
                linkLabel1.Text = "ocultar clave";
                textBox2.Focus();
            }
            else {
                linkLabel1.Text = "ver clave";
                textBox2.PasswordChar = '*';
                textBox2.Focus();
            }

          
        }

        private void linkLabel1_Enter(object sender, EventArgs e)
        {
            


        }
    }
    }
    

