namespace Prototipo_Interfaz
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel7 = new System.Windows.Forms.Panel();
            this.button4 = new System.Windows.Forms.Button();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.panel6 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.b = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.Artista = new System.Windows.Forms.Button();
            this.Album = new System.Windows.Forms.Button();
            this.Cancion = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.trackBar1 = new System.Windows.Forms.TrackBar();
            this.stop = new System.Windows.Forms.Button();
            this.play = new System.Windows.Forms.Button();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel9 = new System.Windows.Forms.Panel();
            this.NombreAlbum1 = new System.Windows.Forms.TextBox();
            this.nombreArtista1 = new System.Windows.Forms.TextBox();
            this.nombreCancion1 = new System.Windows.Forms.TextBox();
            this.panel8 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.NombreAlbum = new System.Windows.Forms.TextBox();
            this.nombreArtista = new System.Windows.Forms.TextBox();
            this.nombreCancion = new System.Windows.Forms.TextBox();
            this.fileSystemWatcher1 = new System.IO.FileSystemWatcher();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.button2 = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).BeginInit();
            this.panel4.SuspendLayout();
            this.panel9.SuspendLayout();
            this.panel8.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcher1)).BeginInit();
            this.SuspendLayout();
            // 
            // imageList1
            // 
            this.imageList1.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.imageList1.ImageSize = new System.Drawing.Size(16, 16);
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            this.panel1.Controls.Add(this.panel7);
            this.panel1.Controls.Add(this.button4);
            this.panel1.Controls.Add(this.textBox2);
            this.panel1.Controls.Add(this.panel6);
            this.panel1.Controls.Add(this.panel5);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(270, 657);
            this.panel1.TabIndex = 0;
            // 
            // panel7
            // 
            this.panel7.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel7.BackgroundImage")));
            this.panel7.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.panel7.Location = new System.Drawing.Point(12, 202);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(52, 39);
            this.panel7.TabIndex = 5;
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.ForeColor = System.Drawing.Color.White;
            this.button4.Location = new System.Drawing.Point(79, 202);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(137, 39);
            this.button4.TabIndex = 4;
            this.button4.Text = "File Explore";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // textBox2
            // 
            this.textBox2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            this.textBox2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox2.ForeColor = System.Drawing.Color.DarkOrange;
            this.textBox2.Location = new System.Drawing.Point(12, 157);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 24);
            this.textBox2.TabIndex = 2;
            this.textBox2.Text = "MAIN";
            this.textBox2.TextChanged += new System.EventHandler(this.textBox2_TextChanged_1);
            // 
            // panel6
            // 
            this.panel6.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel6.BackgroundImage")));
            this.panel6.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.panel6.Location = new System.Drawing.Point(91, 0);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(70, 66);
            this.panel6.TabIndex = 1;
            // 
            // panel5
            // 
            this.panel5.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel5.BackgroundImage")));
            this.panel5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.panel5.Controls.Add(this.textBox1);
            this.panel5.Controls.Add(this.b);
            this.panel5.Location = new System.Drawing.Point(12, 65);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(237, 33);
            this.panel5.TabIndex = 0;
            // 
            // textBox1
            // 
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox1.Font = new System.Drawing.Font("Century", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(32, 8);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(195, 19);
            this.textBox1.TabIndex = 2;
            // 
            // b
            // 
            this.b.AutoEllipsis = true;
            this.b.BackColor = System.Drawing.Color.Transparent;
            this.b.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.b.FlatAppearance.BorderSize = 0;
            this.b.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.b.ForeColor = System.Drawing.Color.Transparent;
            this.b.Location = new System.Drawing.Point(3, 3);
            this.b.Name = "b";
            this.b.Size = new System.Drawing.Size(23, 18);
            this.b.TabIndex = 0;
            this.b.Text = "button1";
            this.b.UseVisualStyleBackColor = false;
            this.b.Visible = false;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.panel2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel2.BackgroundImage")));
            this.panel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.panel2.Controls.Add(this.Artista);
            this.panel2.Controls.Add(this.Album);
            this.panel2.Controls.Add(this.Cancion);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(270, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1137, 186);
            this.panel2.TabIndex = 1;
            // 
            // Artista
            // 
            this.Artista.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Artista.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Artista.ForeColor = System.Drawing.Color.White;
            this.Artista.Location = new System.Drawing.Point(146, 155);
            this.Artista.Name = "Artista";
            this.Artista.Size = new System.Drawing.Size(104, 25);
            this.Artista.TabIndex = 4;
            this.Artista.Text = "Artista";
            this.Artista.UseVisualStyleBackColor = true;
            this.Artista.MouseEnter += new System.EventHandler(this.OnGotFocusHandlerArtista);
            this.Artista.MouseLeave += new System.EventHandler(this.OnLostFocusHandlerArtista);
            // 
            // Album
            // 
            this.Album.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Album.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Album.ForeColor = System.Drawing.Color.White;
            this.Album.Location = new System.Drawing.Point(265, 155);
            this.Album.Name = "Album";
            this.Album.Size = new System.Drawing.Size(104, 25);
            this.Album.TabIndex = 3;
            this.Album.Text = "Album";
            this.Album.UseVisualStyleBackColor = true;
            this.Album.Click += new System.EventHandler(this.Album_Click);
            this.Album.MouseEnter += new System.EventHandler(this.OnGotFocusHandlerAlbum);
            this.Album.MouseLeave += new System.EventHandler(this.OnLostFocusHandlerAlbum);
            // 
            // Cancion
            // 
            this.Cancion.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Cancion.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Cancion.ForeColor = System.Drawing.Color.White;
            this.Cancion.Location = new System.Drawing.Point(36, 155);
            this.Cancion.Name = "Cancion";
            this.Cancion.Size = new System.Drawing.Size(104, 25);
            this.Cancion.TabIndex = 2;
            this.Cancion.Text = "Cancion";
            this.Cancion.UseVisualStyleBackColor = true;
            this.Cancion.Click += new System.EventHandler(this.Cancion_Click);
            this.Cancion.MouseEnter += new System.EventHandler(this.OnGotFocusHandlerCancion);
            this.Cancion.MouseLeave += new System.EventHandler(this.OnLostFocusHandlerCancion);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.panel3.Controls.Add(this.trackBar1);
            this.panel3.Controls.Add(this.stop);
            this.panel3.Controls.Add(this.play);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel3.Location = new System.Drawing.Point(270, 557);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1137, 100);
            this.panel3.TabIndex = 2;
            // 
            // trackBar1
            // 
            this.trackBar1.AccessibleRole = System.Windows.Forms.AccessibleRole.ProgressBar;
            this.trackBar1.AutoSize = false;
            this.trackBar1.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.trackBar1.Location = new System.Drawing.Point(1068, 11);
            this.trackBar1.Name = "trackBar1";
            this.trackBar1.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.trackBar1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.trackBar1.Size = new System.Drawing.Size(45, 77);
            this.trackBar1.SmallChange = 0;
            this.trackBar1.TabIndex = 0;
            this.trackBar1.TabStop = false;
            this.trackBar1.TickFrequency = 0;
            // 
            // stop
            // 
            this.stop.Location = new System.Drawing.Point(146, 42);
            this.stop.Name = "stop";
            this.stop.Size = new System.Drawing.Size(75, 23);
            this.stop.TabIndex = 3;
            this.stop.Text = "Stop";
            this.stop.UseVisualStyleBackColor = true;
            this.stop.Click += new System.EventHandler(this.stop_Click);
            // 
            // play
            // 
            this.play.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.play.Location = new System.Drawing.Point(36, 42);
            this.play.Name = "play";
            this.play.Size = new System.Drawing.Size(75, 23);
            this.play.TabIndex = 2;
            this.play.Text = "Play";
            this.play.UseVisualStyleBackColor = true;
            this.play.Click += new System.EventHandler(this.play_Click);
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(20)))));
            this.panel4.Controls.Add(this.panel9);
            this.panel4.Controls.Add(this.panel8);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel4.Location = new System.Drawing.Point(270, 186);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(1137, 371);
            this.panel4.TabIndex = 3;
            // 
            // panel9
            // 
            this.panel9.Controls.Add(this.button2);
            this.panel9.Controls.Add(this.NombreAlbum1);
            this.panel9.Controls.Add(this.nombreArtista1);
            this.panel9.Controls.Add(this.nombreCancion1);
            this.panel9.Location = new System.Drawing.Point(0, 95);
            this.panel9.Name = "panel9";
            this.panel9.Size = new System.Drawing.Size(1137, 83);
            this.panel9.TabIndex = 2;
            // 
            // NombreAlbum1
            // 
            this.NombreAlbum1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(20)))));
            this.NombreAlbum1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.NombreAlbum1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NombreAlbum1.ForeColor = System.Drawing.Color.White;
            this.NombreAlbum1.Location = new System.Drawing.Point(596, 35);
            this.NombreAlbum1.Name = "NombreAlbum1";
            this.NombreAlbum1.Size = new System.Drawing.Size(100, 17);
            this.NombreAlbum1.TabIndex = 5;
            this.NombreAlbum1.Text = "Album";
            // 
            // nombreArtista1
            // 
            this.nombreArtista1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(20)))));
            this.nombreArtista1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.nombreArtista1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nombreArtista1.ForeColor = System.Drawing.Color.White;
            this.nombreArtista1.Location = new System.Drawing.Point(376, 35);
            this.nombreArtista1.Name = "nombreArtista1";
            this.nombreArtista1.Size = new System.Drawing.Size(84, 17);
            this.nombreArtista1.TabIndex = 3;
            this.nombreArtista1.Text = "Artista";
            // 
            // nombreCancion1
            // 
            this.nombreCancion1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(20)))));
            this.nombreCancion1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.nombreCancion1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nombreCancion1.ForeColor = System.Drawing.Color.White;
            this.nombreCancion1.Location = new System.Drawing.Point(180, 35);
            this.nombreCancion1.Name = "nombreCancion1";
            this.nombreCancion1.Size = new System.Drawing.Size(152, 17);
            this.nombreCancion1.TabIndex = 0;
            this.nombreCancion1.Text = "Cancion";
            this.nombreCancion1.TextChanged += new System.EventHandler(this.nombreCancion1_TextChanged);
            // 
            // panel8
            // 
            this.panel8.Controls.Add(this.button1);
            this.panel8.Controls.Add(this.NombreAlbum);
            this.panel8.Controls.Add(this.nombreArtista);
            this.panel8.Controls.Add(this.nombreCancion);
            this.panel8.Location = new System.Drawing.Point(0, 0);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(1137, 89);
            this.panel8.TabIndex = 1;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Transparent;
            this.button1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button1.BackgroundImage")));
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Location = new System.Drawing.Point(42, 11);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(79, 69);
            this.button1.TabIndex = 3;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // NombreAlbum
            // 
            this.NombreAlbum.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(20)))));
            this.NombreAlbum.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.NombreAlbum.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NombreAlbum.ForeColor = System.Drawing.Color.White;
            this.NombreAlbum.Location = new System.Drawing.Point(596, 35);
            this.NombreAlbum.Name = "NombreAlbum";
            this.NombreAlbum.Size = new System.Drawing.Size(100, 17);
            this.NombreAlbum.TabIndex = 5;
            this.NombreAlbum.Text = "Album";
            // 
            // nombreArtista
            // 
            this.nombreArtista.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(20)))));
            this.nombreArtista.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.nombreArtista.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nombreArtista.ForeColor = System.Drawing.Color.White;
            this.nombreArtista.Location = new System.Drawing.Point(376, 35);
            this.nombreArtista.Name = "nombreArtista";
            this.nombreArtista.Size = new System.Drawing.Size(84, 17);
            this.nombreArtista.TabIndex = 3;
            this.nombreArtista.Text = "Artista";
            this.nombreArtista.TextChanged += new System.EventHandler(this.nombreCancion_TextChanged);
            // 
            // nombreCancion
            // 
            this.nombreCancion.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(20)))));
            this.nombreCancion.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.nombreCancion.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nombreCancion.ForeColor = System.Drawing.Color.White;
            this.nombreCancion.Location = new System.Drawing.Point(180, 35);
            this.nombreCancion.Name = "nombreCancion";
            this.nombreCancion.Size = new System.Drawing.Size(152, 17);
            this.nombreCancion.TabIndex = 0;
            this.nombreCancion.Text = "Cancion";
            this.nombreCancion.TextChanged += new System.EventHandler(this.nombreCancion_TextChanged);
            // 
            // fileSystemWatcher1
            // 
            this.fileSystemWatcher1.EnableRaisingEvents = true;
            this.fileSystemWatcher1.SynchronizingObject = this;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Transparent;
            this.button2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button2.BackgroundImage")));
            this.button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Location = new System.Drawing.Point(42, 3);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(79, 69);
            this.button2.TabIndex = 4;
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1407, 657);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).EndInit();
            this.panel4.ResumeLayout(false);
            this.panel9.ResumeLayout(false);
            this.panel9.PerformLayout();
            this.panel8.ResumeLayout(false);
            this.panel8.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcher1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Button b;
        private System.Windows.Forms.Panel panel4;
        private System.IO.FileSystemWatcher fileSystemWatcher1;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Button Cancion;
        private System.Windows.Forms.Button Artista;
        private System.Windows.Forms.Button Album;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.TrackBar trackBar1;
        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.TextBox nombreArtista;
        private System.Windows.Forms.TextBox nombreCancion;
        private System.Windows.Forms.TextBox NombreAlbum;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.Button play;
        private System.Windows.Forms.Button stop;
        private System.Windows.Forms.Panel panel9;
        private System.Windows.Forms.TextBox NombreAlbum1;
        private System.Windows.Forms.TextBox nombreArtista1;
        private System.Windows.Forms.TextBox nombreCancion1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}

