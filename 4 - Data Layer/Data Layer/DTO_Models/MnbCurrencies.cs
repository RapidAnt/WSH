using System.Collections.Generic;
using System.Xml.Serialization;

namespace Data_Layer.DTO_Models
{
    [XmlRoot("MNBCurrencies")]
    public class MnbCurrencies
    {
        [XmlArray("Currencies")]
        [XmlArrayItem("Curr")]
        public List<Currency> Currencies { get; set; }
    }
}
