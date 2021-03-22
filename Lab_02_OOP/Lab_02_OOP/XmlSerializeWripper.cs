using System;
using System.IO;
using System.Windows.Forms;
using System.Xml.Serialization;

namespace Lab_02_OOP
{
    public static class XmlSerializeWrapper
    {
        public static void Serialize<T>(T obj, string filename)
        {
            var formatter = new XmlSerializer(typeof(T));
            using (var fs = new FileStream(filename, FileMode.OpenOrCreate))
            {
                formatter.Serialize(fs, obj);
            }
        }
        public static T Deserialize<T>(string filename)
        {
            T obj = default;
            using (FileStream fs = new FileStream(filename, FileMode.OpenOrCreate))
            {
                XmlSerializer formatter = new XmlSerializer(typeof(T));
                try
                {
                    obj = (T) formatter.Deserialize(fs);
                }
                catch (Exception e)
                {
                    MessageBox.Show(e.Message);
                }
            }
            return obj;
        }
    }

}