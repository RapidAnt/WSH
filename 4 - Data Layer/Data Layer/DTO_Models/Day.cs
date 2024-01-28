using System.Collections.Generic;
using System.Xml.Serialization;

namespace Data_Layer.DTO_Models
{
    public class Day
    {
        [XmlAttribute("date")]
        public string Date { get; set; }

        [XmlElement("Rate")]
        public List<Rate> Rates { get; set; }
    }
}
