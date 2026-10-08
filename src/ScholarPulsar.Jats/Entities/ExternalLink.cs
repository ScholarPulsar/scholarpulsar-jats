using System;
using System.Xml.Serialization;

namespace ScholarPulsar.Jats.Entities
{
    [Serializable]
    [XmlRoot(ElementName = "ext-link")]
    public class ExternalLink : InnerXmlElement
    {
        [XmlAttribute(AttributeName = "ext-link-type")]
        public string Type
        {
            get;
            set;
        }

        [XmlAttribute(AttributeName = "href", Namespace = "http://www.w3.org/1999/xlink")]
        public string Href
        {
            get;
            set;
        }
    }
}