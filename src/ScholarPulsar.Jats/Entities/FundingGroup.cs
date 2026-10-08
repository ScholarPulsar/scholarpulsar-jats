using System;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace ScholarPulsar.Jats.Entities
{
    [Serializable]
    [XmlRoot(ElementName = "funding-group")]

    public class FundingGroup
    {
        [XmlAttribute(AttributeName = "id")]
        public string Id
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

        [XmlElement(ElementName = "award-group")]
        public List<AwardGroup> AwardGroups
        {
            get;set;
        }

        [XmlElement(ElementName = "funding-statement")]
        public List<FundingStatement> FundingStatements
        {
            get;set;
        }

        [XmlElement(ElementName = "open-access")]
        public List<OpenAccess> OpenAccesses
        {
            get;set;
        }
    }
}