using System.Xml.Serialization;

namespace Data_Layer.DTO_Models
{
    public class Rate
    {
        [XmlAttribute("unit")]
        public string Unit { get; set; }

        [XmlAttribute("curr")]
        public string Curr { get; set; }

        [XmlText()]
        public string CurrentRate { get; set; }
    }
}
