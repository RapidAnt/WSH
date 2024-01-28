using System.Xml.Serialization;

namespace Data_Layer.DTO_Models
{
    [XmlRoot("MNBExchangeRates")]
    public class MnbExchangeRates
    {
        [XmlElement("Day")]
        public Day[] Days { get; set; }
    }
}
