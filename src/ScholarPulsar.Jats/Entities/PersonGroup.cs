using ScholarPulsar.Jats.Base;
using System;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace ScholarPulsar.Jats.Entities
{
    [Serializable]
    [XmlRoot(ElementName = "person-group")]
    public class PersonGroup : ContributorNamingElement
    {
        [XmlAttribute(AttributeName = "id")]
        public string Id
        {
            get; set;
        }

        [XmlAttribute(AttributeName = "person-group-type")]
        public string PersonGroupType
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

        [XmlElement("collab-alternatives", typeof(CollaborationAlternatives))]
        [XmlElement("collab", typeof(CollaborativeAuthor))]
        [XmlElement("name", typeof(PersonName))]
        [XmlElement("string-name", typeof(PersonStringName))]
        [XmlElement("etal", typeof(EtAl))]
        public List<ContributorNamingElement> Names
        {
            get; set;
        }

        [XmlElement(ElementName = "aff")]
        public List<Affiliation> Affiliations
        {
            get; set;
        }

        [XmlElement(ElementName = "aff-alternatives")]
        public AffiliationAlternatives AffiliationAlternatives
        {
            get; set;
        }

        
    }
}