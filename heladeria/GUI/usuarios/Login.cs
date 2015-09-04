using System;
using System.Drawing;
using System.Windows.Forms;
using System.Diagnostics;



namespace heladeria.GUI.usuarios
{
    public partial class Login : Form
    {
        public static backend.VO.usuario Obusuario = null;

        public Login()
        {
            InitializeComponent();
            textBox2.PasswordChar = '*';

            panel1.BackColor = Color.Green;
            panel2.BackColor = Color.LightBlue;
            this.MaximizeBox = false;
            this.AutoSize = true;
            this.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            CenterToScreen();
          // backend.refactory r = new backend.refactory();
          //r.prueba1();

            
        }
       

        private void button1_Click(object sender, EventArgs e)
        {
            onclick(textBox1.Text.Trim(),textBox2.Text.Trim());
        }

        public void onclick(String usuario,String password) {
            backend.usuarios.Login_back lb = new backend.usuarios.Login_back();
             Obusuario = lb.validar(usuario,password);
            if (Obusuario!=null)
            {

               
                PUsuario fact = new PUsuario();
                this.Hide();
                fact.ShowDialog();
                this.Close();
               


            }
            else {
                MessageBox.Show("datos erroneos","eror", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                textBox1.Focus();
                textBox1.SelectAll();
               

            }
            
        }

        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                onclick(textBox1.Text.Trim(),textBox2.Text.Trim());
                
            }
        }
    }
}
