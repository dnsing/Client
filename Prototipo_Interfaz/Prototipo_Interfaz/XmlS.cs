using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Xml.Serialization;

namespace Prototipo_Interfaz
{
    [XmlRoot("XML")]
    public class XmlS
    {
        public XmlS()
        {

        }

       public string opcode { get; set; }
        public string cancionNombre { get; set; }
        public string artista { get; set; }
        public string album { get; set; }
        public string path { get; set; }
        public string song { get; set; }
    
        public void Save(string fileName)
        {
            using (var stream = new FileStream(fileName, FileMode.Create))
            {
                var xml = new XmlSerializer(typeof(XmlS));
                xml.Serialize(stream, this);
            }
        }

      


        public static XmlS LoadFile(String fileName)
        {
            using (var stream = new FileStream(fileName, FileMode.Open))
            {
                var xml = new XmlSerializer(typeof(XmlS));
                return (XmlS)xml.Deserialize(stream);
            }
        }

    }
}
