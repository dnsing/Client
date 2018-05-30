namespace Prototipo_Interfaz
{
    partial class Form2
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.button1 = new System.Windows.Forms.Button();
            this.usuario = new System.Windows.Forms.TextBox();
            this.contrasena = new System.Windows.Forms.TextBox();
            this.signup = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(358, 238);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "Ingresar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // usuario
            // 
            this.usuario.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.usuario.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.usuario.Location = new System.Drawing.Point(301, 94);
            this.usuario.Name = "usuario";
            this.usuario.Size = new System.Drawing.Size(204, 13);
            this.usuario.TabIndex = 1;
            this.usuario.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.usuario.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // contrasena
            // 
            this.contrasena.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.contrasena.Location = new System.Drawing.Point(301, 122);
            this.contrasena.Name = "contrasena";
            this.contrasena.PasswordChar = '*';
            this.contrasena.Size = new System.Drawing.Size(204, 13);
            this.contrasena.TabIndex = 2;
            this.contrasena.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // signup
            // 
            this.signup.BackColor = System.Drawing.SystemColors.Desktop;
            this.signup.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.signup.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.signup.ForeColor = System.Drawing.Color.White;
            this.signup.Location = new System.Drawing.Point(344, 311);
            this.signup.Name = "signup";
            this.signup.ReadOnly = true;
            this.signup.Size = new System.Drawing.Size(100, 13);
            this.signup.TabIndex = 3;
            this.signup.Text = "Sign Up";
            this.signup.Click += new System.EventHandler(this.sign_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.signup);
            this.Controls.Add(this.contrasena);
            this.Controls.Add(this.usuario);
            this.Controls.Add(this.button1);
            this.Name = "Form2";
            this.Text = "Form2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox usuario;
        private System.Windows.Forms.TextBox contrasena;
        private System.Windows.Forms.TextBox signup;
    }
}