using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Serialization;

namespace Cafe
{
    public class SerializeService
    {
        static XmlSerializer serializer;
        public static void ObjSerialize(ISerialize obj, Type type)
        {
            XmlSerialize(type, obj);
        }
        public static ISerialize ObjDeserialize(Type type, ISerialize obj)
        {
            return XmlDeserialize(type, obj);
        }
        private static ISerialize XmlDeserialize(Type type, ISerialize obj)
        {
            serializer = new XmlSerializer(type);
            try
            {
                //if (File.Exists("users.xml") == false) return;
                using (FileStream fs = new FileStream($"{obj.FileName}.xml", FileMode.Open))
                {
                    obj = (ISerialize)serializer.Deserialize(fs);
                }
            }
            catch (Exception)
            {
                
            }

            return obj;
        }
        private static void XmlSerialize(Type type, ISerialize obj)
        {
            serializer = new XmlSerializer(type);
            try
            {
                using (FileStream fs = new FileStream($"{obj.FileName}.xml", FileMode.Create))
                {
                    serializer.Serialize(fs, obj);
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }
    }
}
