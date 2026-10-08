using System.Xml.Serialization;
using System;
using System.Collections.Generic;

namespace ScholarPulsar.Jats.Entities
{
    [Serializable]
    [XmlRoot(ElementName = "funding-source")]
    public class FundingSource
    {
        [XmlAttribute(AttributeName = "source-type")]
        public string SourceType
        {
            get; set;
        }

        [XmlElement(ElementName = "institution-wrap")]
        public List<InstitutionWrap> InstitutionWrap { get; set; }

        [XmlElement(ElementName = "institution")]
        public List<Institution> Institutions { get; set; }
    }
}