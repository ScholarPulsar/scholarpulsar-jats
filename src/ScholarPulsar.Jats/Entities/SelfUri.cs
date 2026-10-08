using System;
using System.Xml.Serialization;

namespace ScholarPulsar.Jats.Entities
{
    [Serializable]
    [XmlRoot(ElementName = "self-uri")]
    public class SelfUri : InnerXmlElement
    {
        [XmlAttribute(AttributeName = "content-type")]
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