using System;
using System.Xml.Serialization;

namespace ScholarPulsar.Jats.Entities
{
    [Serializable]
    [XmlRoot(ElementName = "funding-statement")]
    public class FundingStatement : InnerXmlElement
    {
        [XmlAttribute(AttributeName = "id")]
        public string Id
        {
            get; set;
        }
    }
}