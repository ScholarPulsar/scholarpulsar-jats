using System;
using System.Xml.Serialization;

namespace ScholarPulsar.Jats.Entities
{
    [Serializable]
    [XmlRoot(ElementName = "uri")]
    public class UniformResourceIdentifier : InnerXmlElement
    {
        [XmlAttribute(AttributeName = "content-type")]
        public string ContentType
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