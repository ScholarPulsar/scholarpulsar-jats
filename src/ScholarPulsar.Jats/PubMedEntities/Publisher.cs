using System;
using System.Collections.Generic;
using System.Text;
using System.Xml.Serialization;

namespace ScholarPulsar.Jats.PubMedEntities
{
    [XmlRoot(ElementName = "Publisher")]
    public class Publisher
    {
        [XmlElement(ElementName = "PublisherName")]
        public string PublisherName { get; set; }

        [XmlElement(ElementName = "PublisherLocation")]
        public string PublisherLocation { get; set; }
    }
}
