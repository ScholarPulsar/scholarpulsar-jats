using System;
using System.Collections.Generic;
using System.Text;
using System.Xml.Serialization;

namespace ScholarPulsar.Jats.Entities
{
    [XmlRoot(ElementName = "mixed-citation")]
    public class MixedCitation : InnerXmlElement
    {
        [XmlAttribute(AttributeName = "publication-type")]
        public string PublicationType { get; set; }
    }
}
