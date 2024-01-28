using System.Xml.Serialization;

namespace Data_Layer.DTO_Models
{
    public class DateInterval
    {
        [XmlAttribute("startdate")]
        public string StartDate { get; set; }
        [XmlAttribute("enddate")]
        public string EndDate { get; set; }
    }
}
