using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;
using NAudio.Wave;
using NAudio.Wave.SampleProviders;


namespace Prototipo_Interfaz
{
    public partial class Form1 : Form
    {
        private WaveOutEvent outputDevice;
        private AudioFileReader audioFile;
        public static byte[] audiobyte;
        public static String file;
        public static int cont = -1;
        public static string path1;
        public static string path2;
        public Form1()
        {
            InitializeComponent();
        }

        static Songdata sg = new Songdata();
        Client cliente = new Client();

        BlockAlignReductionStream stream = null;
        static DirectSoundOut output = new DirectSoundOut();
        static Mp3FileReader mp3 = null;



        private void Form1_Load(object sender, EventArgs e)
        {
            
            //ShowInTaskbar = false;
          //  this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
        }

        private void OnGotFocusHandlerCancion(object sender, EventArgs e)
        {
           
            Cancion.BackColor = Color.Orange;
            Cancion.ForeColor = Color.Black;
        }
    
        private void OnLostFocusHandlerCancion(object sender, EventArgs e)
        {
            Cancion.BackColor = Color.Black;
            Cancion.ForeColor = Color.White;
            
        }

        private void OnGotFocusHandlerArtista(object sender, EventArgs e)
        {

            Artista.BackColor = Color.Orange;
            Artista.ForeColor = Color.Black;
        }

        private void OnLostFocusHandlerArtista(object sender, EventArgs e)
        {
            Artista.BackColor = Color.Black;
            Artista.ForeColor = Color.White;

        }

        private void OnGotFocusHandlerAlbum(object sender, EventArgs e)
        {

            Album.BackColor = Color.Orange;
            Album.ForeColor = Color.Black;
        }

        private void OnLostFocusHandlerAlbum(object sender, EventArgs e)
        {
            Album.BackColor = Color.Black;
            Album.ForeColor = Color.White;

        }


        //borrar
        private void textBox2_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void button4_Click(object sender, EventArgs e)
        {
            sg.Show();
            cont++;
            
        }

        public void xml(string path)
        {
            file = "a.xml";
            //String file1 = "C:\\Users\\danie\\a.xml";
            audiobyte = File.ReadAllBytes(path);
            String base64String = Convert.ToBase64String(audiobyte);
            XmlS data = new XmlS();

            data.opcode = "0";
            data.cancionNombre = sg.getNombre();
            data.artista = sg.getArtista();
            data.album = sg.getAlbum();
            data.path = path;
            data.song = base64String;
            data.Save(file);
          //  data.Save(file1);
            cliente.mandelo("a");

        }
      
        private void Album_Click(object sender, EventArgs e)
        {
            
        }

        private void play_Click(object sender, EventArgs e)
        {

            Stream play = new MemoryStream(audiobyte);
            mp3 = new Mp3FileReader(play);
            output = new DirectSoundOut();
            output.Init(mp3);
            output.Play();
        }

        private void stop_Click(object sender, EventArgs e)
        {
            output.Stop();
        }


        private void nombreCancion_TextChanged(object sender, EventArgs e)
        {
            if (cont == 0)
            {
                path1 = Songdata.path1;
                nombreCancion.Text = Songdata.nombreC;
                nombreArtista.Text = Songdata.artistaN;
                NombreAlbum.Text = Songdata.albumN;
            }
        }

        private void nombreCancion1_TextChanged(object sender, EventArgs e)
        {
            if (cont == 1)
            {
                path2 = Songdata.path1;
                nombreCancion1.Text = Songdata.nombreC;
                nombreArtista1.Text = Songdata.artistaN;
                NombreAlbum1.Text = Songdata.albumN;
            }
        }
        
        private void Cancion_Click(object sender, EventArgs e)
        {
            QuickSort qs = new QuickSort();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Stream play = new MemoryStream(File.ReadAllBytes(path1));
            mp3 = new Mp3FileReader(play);
            output = new DirectSoundOut();
            output.Init(mp3);
            output.Play();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Stream play = new MemoryStream(File.ReadAllBytes(path2));
            mp3 = new Mp3FileReader(play);
            output = new DirectSoundOut();
            output.Init(mp3);
            output.Play();
        }
    }
}
