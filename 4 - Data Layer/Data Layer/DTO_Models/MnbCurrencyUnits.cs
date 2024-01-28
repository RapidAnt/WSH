using System.Collections.Generic;
using System.Xml.Serialization;

namespace Data_Layer.DTO_Models
{
    [XmlRoot("MNBCurrencyUnits")]
    public class MnbCurrencyUnits
    {
        [XmlArray("Units")]
        [XmlArrayItem("Unit")]
        public List<UnitElement> Units { get; set; }
    }
}
