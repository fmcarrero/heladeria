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
    public partial class PUsuario : Form
    {
        private addUser mOpener = new addUser();
        private  List<String> listUserAutorizeForm = new List<string>();
        public addUser Opener
        {
            set { this.mOpener = value; }
        }

        public PUsuario()
        {
            InitializeComponent();
            Screen screen = Screen.PrimaryScreen;
            int Height = screen.Bounds.Width;
            int Width = screen.Bounds.Height;

            this.Height = Width;
            this.Width = Height;
            backend.leerXml le = new backend.leerXml();
            String var=le.leer("nombre");
            label2.Text =var;
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
            comboBox1.DataSource = backend.usuarios.usuarios_back.llenar_combo();
            comboBox1.Text = "usuario";
            dataGridView1.Height = this.Height-220;
            label6.Text = "USUARIOS";
            dataGridView1.Visible = false;

           
            listUserAutorizeForm.Add("control total");

        }
       

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("hello");
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process calc = new System.Diagnostics.Process { StartInfo = { FileName = @"calc.exe" } };
            calc.Start();
        }

        private void pictureBox2_MouseUp(object sender, MouseEventArgs e)
        {
           
        }
        public void cambiador(KeyEventArgs e)
        {
            if (e.KeyData == (Keys.F5))
            {
                comboBox1.Text = "usuario";

            }
            else if (e.KeyData == (Keys.F6))
            {
                comboBox1.Text = "clave";
            }
            else if (e.KeyData == (Keys.F7))
            {
                comboBox1.Text = "DESCRIPCION";
            }
            else if (e.KeyData == (Keys.F8))
            {
                comboBox1.Text = "id_permiso";
            }
        }

        private void pictureBox2_MouseHover(object sender, EventArgs e)
        {
            //aca
            this.Cursor = Cursors.Hand;
        }

        private void pictureBox2_MouseLeave(object sender, EventArgs e)
        {
            this.Cursor = Cursors.Default;
        }
                    
        private void pictureBox1_MouseHover_1(object sender, EventArgs e)
        {
            this.Cursor = Cursors.Hand;
        }

        private void pictureBox1_MouseLeave(object sender, EventArgs e)
        {
            //aca
            this.Cursor = Cursors.Default;
        }

        private void comboBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void comboBox1_KeyDown(object sender, KeyEventArgs e)
        {
            cambiador(e);
        }

        private void textBox1_KeyDown(object sender, KeyEventArgs e)
        {

            cambiador(e);
            if (e.KeyCode == Keys.Insert)
            {

                addUser addUSER = new addUser();
                addUSER.Show();

            }


        }

        private void pictureBox4_MouseHover(object sender, EventArgs e)
        {
            this.Cursor = Cursors.Hand;
        }

        private void pictureBox4_MouseLeave(object sender, EventArgs e)
        {
            this.Cursor = Cursors.Default;
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            //codigo para al dar enter
            dataGridView1.DataSource = backend.usuarios.usuarios_back.listarUsuarios(comboBox1.Text,textBox1.Text);
            dataGridView1.Columns[0].Width = this.dataGridView1.Width / 4;
            dataGridView1.Columns[1].Width = this.dataGridView1.Width / 4;
            dataGridView1.Columns[2].Width = this.dataGridView1.Width / 4;
            dataGridView1.Columns[3].Width = this.dataGridView1.Width / 5;
           
        }

        private void pictureBox5_MouseHover(object sender, EventArgs e)
        {
            this.Cursor = Cursors.Hand;
        }

        private void pictureBox5_MouseLeave(object sender, EventArgs e)
        {
            this.Cursor = Cursors.Default;
        }

        private void pictureBox6_MouseHover(object sender, EventArgs e)
        {
            this.Cursor = Cursors.Hand;
        }

        private void pictureBox6_MouseLeave(object sender, EventArgs e)
        {
            this.Cursor = Cursors.Default;
        }

        

        private void textBox1_Enter(object sender, EventArgs e)
        {
           
        }

        

        private void textBox1_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                dataGridView1.DataSource = backend.usuarios.usuarios_back.listarUsuarios(comboBox1.Text, textBox1.Text);
                dataGridView1.Columns[0].Width = this.dataGridView1.Width / 4;
                dataGridView1.Columns[1].Width = this.dataGridView1.Width / 4;
                dataGridView1.Columns[2].Width = this.dataGridView1.Width / 4;
                dataGridView1.Columns[3].Width = this.dataGridView1.Width / 5;

                textBox1.SelectAll();
            }
            if (e.KeyChar == Convert.ToChar(Keys.Insert))
            {
                addUser addUSER = new addUser();
                addUSER.Show();

            }

            }

        private void dataGridView1_KeyPress(object sender, KeyPressEventArgs e)
        {
            
        }

        private void pictureBox9_Click(object sender, EventArgs e)
        {

            addUser addUSER = new addUser();
            addUSER.Show();
        }

        private void PUsuario_Deactivate(object sender, EventArgs e)
        {
           
        }

        private void PUsuario_Activated(object sender, EventArgs e)
        {
            
            dataGridView1.DataSource = backend.usuarios.usuarios_back.listarUsuarios(comboBox1.Text, textBox1.Text);
            dataGridView1.Columns[0].Width = this.dataGridView1.Width / 4;
            dataGridView1.Columns[1].Width = this.dataGridView1.Width / 4;
            dataGridView1.Columns[2].Width = this.dataGridView1.Width / 4;
            dataGridView1.Columns[3].Width = this.dataGridView1.Width / 5;
            dataGridView1.Columns[3].HeaderText = "Permiso";
        }

        private void pictureBox7_MouseHover(object sender, EventArgs e)
        {
            this.Cursor = Cursors.Hand;

        }

        private void pictureBox7_MouseLeave(object sender, EventArgs e)
        {
            this.Cursor = Cursors.Default;
        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {
            //aca
            var selectedCell = dataGridView1.SelectedCells[0];
            string var = Convert.ToString(selectedCell.Value);
            function(var);
        }

        public void function(String var) {
            
            DialogResult result = MessageBox.Show("desea eliminar al usuario " + var, "Eliminar", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                //code for Yes

                int retur = backend.usuarios.usuarios_back.elimiarUser(var);
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

        private void pictureBox9_MouseHover(object sender, EventArgs e)
        {
            this.Cursor = Cursors.Hand;
        }

        private void pictureBox9_MouseLeave(object sender, EventArgs e)
        {
            this.Cursor = Cursors.Default;
        }

        private void toolStripMenuItem5_Click(object sender, EventArgs e)
        {
            
            Proveedor P = new Proveedor();
            this.Hide();
            P.ShowDialog();
            this.Close();
           
           

        }

        private void PUsuario_Load(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_KeyDown_1(object sender, KeyEventArgs e)
        {
            var selectedCell = dataGridView1.SelectedCells[0];
            string var = Convert.ToString(selectedCell.Value);
            if (e.KeyCode == Keys.Delete)
            {
                function(var);
            }
            if (e.KeyCode == Keys.Insert)
            {

                addUser addUSER = new addUser();
                addUSER.Show();

            }
            if (e.KeyCode == Keys.Enter)
            {

                if (this.mOpener != null)
                {
                    this.mOpener.prueba(var);
                    // addUser addUSER = new addUser();

                    mOpener.ShowDialog();


                }
                else
                {
                    MessageBox.Show("pailas");
                }



            }

        }

        public Boolean userAutorize(String permiso) {
            Boolean saber = false;
            
            return saber;
        }

        private void usuariosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Boolean saber = listUserAutorizeForm.Contains(GUI.usuarios.Login.Obusuario.Id_Permiso);
            if (saber) dataGridView1.Visible = true;
            else {
                //pendiente modal para cambiar clave
                
            }

        }
    }
}
