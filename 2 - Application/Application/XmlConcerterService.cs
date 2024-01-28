using System.IO;
using System.Xml.Serialization;

namespace Application
{
    public class XmlConcerterService : IConverter
    {
        public T ConvertFrom<T>(string xml)
        {
            T result;

            XmlSerializer serializer = new XmlSerializer(typeof(T));
            using (TextReader reader = new StringReader(xml))
            {
                result = (T)serializer.Deserialize(reader);
            }

            return result;
        }
    }
}
