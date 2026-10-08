using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace ScholarPulsar.Jats.Entities
{
    [Serializable]
    [XmlRoot(ElementName = "award-group")]

    public class AwardGroup
    {
        [XmlAttribute(AttributeName = "award-type")]
        public string AwardType
        {
            get; set;
        }

        [XmlElement(ElementName = "funding-source")]
        public List<FundingSource> FundingSource { get; set; }

        [XmlElement(ElementName = "support-source")]
        public List<SupportSource> SupportSource { get; set; }

        [XmlAttribute(AttributeName = "award-id")]
        public string AwardId
        {
            get; set;
        }
    }
}