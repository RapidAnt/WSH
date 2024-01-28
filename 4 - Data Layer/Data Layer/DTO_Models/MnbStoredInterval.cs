using System.Xml.Serialization;

namespace Data_Layer.DTO_Models
{
    [XmlRoot("MNBStoredInterval")]
    public class MnbStoredInterval
    {
        [XmlElement("DateInterval")]
        public DateInterval DateInterval { get; set; }
    }
}
