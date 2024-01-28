using System.Xml.Serialization;

namespace Data_Layer.DTO_Models
{
    [XmlRoot("MNBCurrentExchangeRates")]
    public class MnbCurrentExchangeRates
    {
        [XmlElement("Day")]
        public Day Day { get; set; }
    }
}
