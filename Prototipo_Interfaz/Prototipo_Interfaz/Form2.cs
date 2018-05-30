using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Prototipo_Interfaz
{
     
    public partial class Form2 : Form
    {
        SignUp sg = new SignUp();
        public Form2()
        {
            InitializeComponent();
            usuario.ForeColor = SystemColors.GrayText;
            usuario.Text = "username";
            contrasena.ForeColor = SystemColors.GrayText;
            contrasena.Text = "password";

            this.usuario.Leave += new EventHandler(this.textBox1_Leave);
            this.usuario.Enter += new EventHandler(this.textBox1_Enter);

            this.contrasena.Leave += new EventHandler(this.textBox2_Leave);
            this.contrasena.Enter += new EventHandler(this.textBox2_Enter);
        }

        private void textBox1_Leave(object sender, EventArgs e)
        {
            if (usuario.Text.Length == 0)
            {
                usuario.Text = "email@email.com";
                usuario.ForeColor = SystemColors.GrayText;
            }
        }

        private void textBox1_Enter(object sender, EventArgs e)
        {
            if (usuario.Text == "email@email.com")
            {
                usuario.Text = "";
                usuario.ForeColor = SystemColors.WindowText;
            }
        }

        private void textBox2_Leave(object sender, EventArgs e)
        {
            if (usuario.Text.Length == 0)
            {
                contrasena.Text = "password";
                contrasena.ForeColor = SystemColors.GrayText;
            }
        }

        private void textBox2_Enter(object sender, EventArgs e)
        {
            if (contrasena.Text == "password")
            {
                contrasena.Text = "";
                contrasena.ForeColor = SystemColors.WindowText;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
      
            if (usuario.Text.Equals(SignUp.Getemail) && sg.GetMD5(contrasena.Text).Equals(SignUp.Getpassword))
            {
                Form1 abrir = new Form1();
                abrir.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("usuario/contraseña incorrecta");
            }
            
        }

        private void sign_Click(object sender, EventArgs e)
        {
            SignUp abrir = new SignUp();
            abrir.Show();
            abrir.Visible = true;
            this.Hide();

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
        }

       
    }
}
