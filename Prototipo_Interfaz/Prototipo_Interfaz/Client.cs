using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Net;
using System.Net.Sockets;
using System.Xml;
using System.Xml.Serialization;
using System.Windows.Forms;

namespace Prototipo_Interfaz
{
    class Client
    {

        TcpClient client = new TcpClient("localhost", 1133);
        SignUp su = new SignUp();
        NetworkStream stream;

        public XmlDocument cargarXml()
        {

            NetworkStream stream = client.GetStream();
            String xml1 = null;
            int parada=1;

            while (parada != 0)
            {
                byte[] buf = new byte[30000];
                parada = stream.Read(buf, 0, 30000);
                string xml = Encoding.ASCII.GetString(buf, 0, parada);
                xml1 += xml;
            }
            stream.Close();

            xml1 += "</song></XML>";
            xml1 = xml1.TrimEnd();
            xml1 = xml1.Replace(Environment.NewLine, "");
            

            XmlDocument doc1 = new XmlDocument();
            doc1.LoadXml(xml1);
            return doc1;
           
        }
     
        public void mandelo(String xml)
        {
            String file = "";

            if (xml.Equals("a"))
            {
                file = "a.xml";
            } else if (xml.Equals("b"))
            {
                file = "b.xml";
            }
            
            

            XmlDocument doc = new XmlDocument();
            doc.Load(file);
            StringWriter sw = new StringWriter();
            XmlTextWriter xw = new XmlTextWriter(sw);

            doc.WriteTo(xw);

            string mensaje = sw.ToString();

            //Para mandar el XML al server
            MemoryStream xmlStream = new MemoryStream();
            doc.Save(xmlStream);

            byte[] mensajeB = xmlStream.ToArray();

            // append newline as server expects a line to be read
            stream = client.GetStream();
            stream.Write(mensajeB, 0, mensajeB.Length);

            
        }

       
    }
}
