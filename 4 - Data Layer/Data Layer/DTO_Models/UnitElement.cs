using System.Xml.Serialization;

namespace Data_Layer.DTO_Models
{
    public class UnitElement
    {
        [XmlAttribute]
        public string curr { get; set; }

        [XmlText]
        public int Unit { get; set; }
    }
}
