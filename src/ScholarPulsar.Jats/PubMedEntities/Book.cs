using System.Xml.Serialization;

namespace ScholarPulsar.Jats.PubMedEntities
{
    [XmlRoot(ElementName = "Book")]
    public class Book
    {
        [XmlElement(ElementName = "Publisher")]
        public Publisher Publisher { get; set; }

        [XmlElement(ElementName = "BookTitle")]
        public BookTitle BookTitle { get; set; }

        [XmlElement(ElementName = "PubDate")]
        public PubDate PubDate { get; set; }

        [XmlElement(ElementName = "Medium")]
        public string Medium { get; set; }
    }
}