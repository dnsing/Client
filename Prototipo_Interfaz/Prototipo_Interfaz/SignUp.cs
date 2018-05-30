using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Prototipo_Interfaz
{
    public partial class SignUp : Form
    {
        public SignUp()
        {
            InitializeComponent();
           

            email.ForeColor = SystemColors.GrayText;
            email.Text = email.Text;

            pass1.ForeColor = SystemColors.GrayText;
            pass1.Text = "password";

            pass2.ForeColor = SystemColors.GrayText;
            pass2.Text = "password";

            
            email.Leave += new EventHandler(this.email_Leave);
            email.Enter += new EventHandler(this.email_Enter);

            pass1.Leave += new EventHandler(this.pass1_Leave);
            pass1.Enter += new EventHandler(this.pass1_Enter);

            pass2.Leave += new EventHandler(this.pass2_Leave);
            pass2.Enter += new EventHandler(this.pass2_Enter);
            
        }
        
        private void email_Leave(object sender, EventArgs e)
        {
            if (email.Text.Length == 0)
            {
                email.Text = "Username";
                email.ForeColor = SystemColors.GrayText;
            }
        }

        private void email_Enter(object sender, EventArgs e)
        {
            if (email.Text == "Email3")
            {
                email.Text = "";
                email.ForeColor = SystemColors.WindowText;
            }
        }

        private void pass1_Leave(object sender, EventArgs e)
        {
            if (pass1.Text.Length == 0)
            {
                pass1.Text = "password";
                pass1.ForeColor = SystemColors.GrayText;
            }
        }

        private void pass1_Enter(object sender, EventArgs e)
        {
            if (pass1.Text == "password")
            {
                pass1.Text = "";
                pass1.ForeColor = SystemColors.WindowText;
            }
        }

        private void pass2_Leave(object sender, EventArgs e)
        {
            if (pass2.Text.Length == 0)
            {
                pass2.Text = "password";
                pass2.ForeColor = SystemColors.GrayText;
            }
        }

        private void pass2_Enter(object sender, EventArgs e)
        {
            if (pass2.Text == "password")
            {
                pass2.Text = "";
                pass2.ForeColor = SystemColors.WindowText;
            }
        }

        private void SignUp_Load(object sender, EventArgs e)
        {

        }
      

            private void button1_Click(object sender, EventArgs e)
        {
            if (pass1.Text == pass2.Text)
            {
               
                mandarXml();
            }
            else
            {
                MessageBox.Show("contrasenas diferentes");
            }
            
        }

        public static string Getemail = "";
        public static string Getpassword = "";
        public void mandarXml()
        {

            Client cliente = new Client();

            Form2 form2 = new Form2();
            form2.Show();
            form2.Visible = true;

            String file = "b.xml";
            String file1 = "C:\\Users\\danie\\b.xml";
            XmlLog log = new XmlLog();

            log.opcode = "1";
            log.username = email.Text;
            log.password = GetMD5(pass1.Text);

            log.Save(file);
            log.Save(file1);
            cliente.mandelo("b");

            Getemail = email.Text;
            Getpassword = GetMD5(pass1.Text);
            this.Hide();
        }

        public string GetMD5(string text)
        {
            MD5CryptoServiceProvider md5 = new MD5CryptoServiceProvider();
            md5.ComputeHash(ASCIIEncoding.ASCII.GetBytes(text));
            byte[] result = md5.Hash;
            StringBuilder str = new StringBuilder();
            for (int i = 1; i < result.Length; i++){
                str.Append(result[i].ToString("X2"));
            }
            return str.ToString();
        }
    }
}
