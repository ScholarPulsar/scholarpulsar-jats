using System.Xml.Serialization;
using System;
using System.Collections.Generic;

namespace ScholarPulsar.Jats.Entities
{
    [Serializable]
    [XmlRoot(ElementName = "support-source")]
    public class SupportSource
    {
        [XmlAttribute(AttributeName = "support-type")]
        public string SupportType
        {
            get; set;
        }

        [XmlAttribute(AttributeName = "country")]
        public string Country
        {
            get; set;
        }

        [XmlElement(ElementName = "institution-wrap")]
        public List<InstitutionWrap> InstitutionWrap { get; set; }

        [XmlElement(ElementName = "institution")]
        public List<Institution> Institutions { get; set; }
    }
}