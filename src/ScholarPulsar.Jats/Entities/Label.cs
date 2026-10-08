using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace ScholarPulsar.Jats.Entities
{
    [Serializable]
    [XmlRoot(ElementName = "label")]
    public class Label : InnerXmlElement
    {
        [XmlAttribute(AttributeName = "id")]
        public string Id
        {
            get; set;
        }

        [XmlAttribute(AttributeName = "alt")]
        public string AlternativeText
        {
            get;set;
        }

        [XmlAttribute(AttributeName = "base", Namespace = "http://www.w3.org/xml/1998/namespace")]
        public string Base
        {
            get; set;
        }

        [XmlAttribute(AttributeName = "lang", Namespace = "http://www.w3.org/xml/1998/namespace")]
        public string Language
        {
            get; set;
        }
    }
}
