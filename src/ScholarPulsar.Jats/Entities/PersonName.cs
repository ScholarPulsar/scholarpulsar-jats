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
    [XmlRoot(ElementName = "name")]
    public class PersonName: ContributorNamingElement
    {
        [XmlAttribute(AttributeName = "content-type")]
        public string ContentType
        {
            get; set;
        }

        [XmlAttribute(AttributeName = "id")]
        public string Id
        {
            get; set;
        }

        [XmlAttribute(AttributeName = "name-style")]
        public string NameStyle
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

        [XmlElement(ElementName = "surname")]
        public Surname Surname
        {
            get; set;
        }

        [XmlElement(ElementName = "given-names")]
        public GivenNames GivenNames
        {
            get; set;
        }

        [XmlElement(ElementName = "suffix")]
        public Suffix Suffix
        {
            get;set;
        }

        [XmlElement(ElementName = "prefix")]
        public Prefix Prefix
        {
            get;set;
        }
    }
}
