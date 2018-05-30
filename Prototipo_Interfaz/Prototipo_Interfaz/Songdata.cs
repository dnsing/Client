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
    public partial class Songdata : Form
    {
        public Songdata()
        {
            InitializeComponent();
        }
        Form1 form1 = new Form1();
        OpenFileDialog ofd = new OpenFileDialog();
        string path;
        public Boolean cerrado = false;
        public static string nombreC = "";
        public static string artistaN = "";
        public static string albumN = "";
        public static string path1 = "";

        public void refresh()
        {
            nombreC = SongName.Text;
            artistaN = Artista.Text;
            albumN = Album.Text;
        }

        private void SongName_TextChanged(object sender, EventArgs e)
        {

        }

        public string getNombre()
        {
            return SongName.Text;
        }

        public string getArtista()
        {
            return Artista.Text;
        }

        public string getAlbum()
        {
            return Album.Text;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            refresh();

            ofd.Filter = "MP3 | *.mp3";
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                
                path = ofd.FileName;
                path1 = ofd.FileName;
            }
            this.Hide();
            form1.xml(path);
           

            cerrado = true;
        }

        public Boolean isClose()
        {
            return cerrado;
        }
    }
}
