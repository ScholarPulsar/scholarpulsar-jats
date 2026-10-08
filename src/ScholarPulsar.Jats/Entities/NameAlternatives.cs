using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace ScholarPulsar.Jats.Entities
{
    [Serializable]
    [XmlRoot(ElementName = "name-alternatives")]
    public class NameAlternatives
    {
        [XmlAttribute(AttributeName = "id")]
        public string Id
        {
            get; set;
        }

        [XmlAttribute(AttributeName = "base", Namespace = "http://www.w3.org/xml/1998/namespace")]
        public string Base
        {
            get; set;
        }

        [XmlElement(ElementName = "name")]
        public List<PersonName> Name
        {
            get;set;
        }

        [XmlElement(ElementName = "string-name")]
        public List<PersonStringName> StringName
        {
            get;set;
        }
    }
}
