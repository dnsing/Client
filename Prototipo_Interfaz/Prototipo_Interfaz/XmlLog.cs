using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Prototipo_Interfaz
{
    [XmlRoot("XML")]
    public class XmlLog
    {
        public XmlLog()
        {

        }
        public string opcode { get; set; }
        public string username { get; set; }
        public string password { get; set; }

        public void Save(string fileName)
        {
            using (var stream = new FileStream(fileName, FileMode.Create))
            {
                var xml = new XmlSerializer(typeof(XmlLog));
                xml.Serialize(stream, this);
            }
        }


        public static XmlLog LoadFile(String fileName)
        {
            using (var stream = new FileStream(fileName, FileMode.Open))
            {
                var xml = new XmlSerializer(typeof(XmlLog));
                return (XmlLog)xml.Deserialize(stream);
            }
        }

    }
}
