using ScholarPulsar.Jats.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace ScholarPulsar.Jats.Entities
{
    [Serializable]
    [XmlRoot(ElementName = "aff")]
    public class Affiliation : InnerXmlElement
    {
        [XmlAttribute(AttributeName = "id")]
        public string Id
        {
            get; set;
        }

        [XmlAttribute(AttributeName = "content-type")]
        public string ContentType
        {
            get; set;
        }

        /// <summary>
        /// Value of the identifier of an associated element; used for linking related elements (for example, <term> to a <def>, <bio> to a <contrib>).
        /// </summary>
        [XmlAttribute(AttributeName = "rid")]
        public string ReferenceToIdentifier
        {
            get; set;
        }

        [XmlAttribute(AttributeName = "specific-use")]
        public string SpecificUse
        {
            get; set;
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

        [XmlElement(ElementName = "label")]
        public Label Label
        {
            get;set;
        }
    }
}
