using System.Xml.Serialization;

namespace Data_Layer.DTO_Models
{
    public class Currency
    {
        [XmlText()]
        public string Curr { get; set; }
    }
}
