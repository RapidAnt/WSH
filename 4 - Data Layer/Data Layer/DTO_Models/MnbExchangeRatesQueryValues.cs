using System.Collections.Generic;
using System.Xml.Serialization;

namespace Data_Layer.DTO_Models
{
    [XmlRoot("MNBExchangeRatesQueryValues")]
    public class MnbExchangeRatesQueryValues
    {
        [XmlElement("FirstDate")]
        public string FirstDate { get; set; }
        [XmlElement("LastDate")]
        public string LastDate { get; set; }
        [XmlArray("Currencies")]
        [XmlArrayItem("Curr")]
        public List<Currency> Currencies { get; set; }
    }
}
