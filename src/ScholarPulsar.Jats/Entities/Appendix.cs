using System;
using System.Collections.Generic;
using System.Text;
using System.Xml.Serialization;

namespace ScholarPulsar.Jats.Entities
{
    [Serializable]
    [XmlRoot(ElementName = "app")]
    public class Appendix
    {
        [XmlAttribute(AttributeName = "id")]
        public string Id
        {
            get; set;
        }

        [XmlElement(ElementName = "title")]
        public Title Title
        {
            get; set;
        }

        [XmlElement("p", typeof(Paragraph))]
        [XmlElement("supplementary-material", typeof(SupplementaryMaterial))]
        public List<ParagraphElement> Elements
        {
            get;
            set;
        }
    }
}
