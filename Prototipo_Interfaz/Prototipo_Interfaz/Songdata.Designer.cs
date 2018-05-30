namespace Prototipo_Interfaz
{
    partial class Songdata
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
            this.SongName = new System.Windows.Forms.TextBox();
            this.Artista = new System.Windows.Forms.TextBox();
            this.Album = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // SongName
            // 
            this.SongName.Location = new System.Drawing.Point(123, 51);
            this.SongName.Name = "SongName";
            this.SongName.Size = new System.Drawing.Size(100, 20);
            this.SongName.TabIndex = 0;
            this.SongName.Text = "Nombre";
            this.SongName.TextChanged += new System.EventHandler(this.SongName_TextChanged);
            // 
            // Artista
            // 
            this.Artista.Location = new System.Drawing.Point(123, 94);
            this.Artista.Name = "Artista";
            this.Artista.Size = new System.Drawing.Size(100, 20);
            this.Artista.TabIndex = 1;
            this.Artista.Text = "Artista";
            // 
            // Album
            // 
            this.Album.Location = new System.Drawing.Point(123, 141);
            this.Album.Name = "Album";
            this.Album.Size = new System.Drawing.Size(100, 20);
            this.Album.TabIndex = 2;
            this.Album.Text = "Album";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(176, 299);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 4;
            this.button1.Text = "listo";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Songdata
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.Album);
            this.Controls.Add(this.Artista);
            this.Controls.Add(this.SongName);
            this.Name = "Songdata";
            this.Text = "Songdata";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox SongName;
        private System.Windows.Forms.TextBox Artista;
        private System.Windows.Forms.TextBox Album;
        private System.Windows.Forms.Button button1;
    }
}