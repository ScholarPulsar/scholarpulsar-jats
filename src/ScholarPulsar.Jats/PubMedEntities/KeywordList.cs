using System;
using System.Collections.Generic;
using System.Text;
using System.Xml.Serialization;

namespace ScholarPulsar.Jats.PubMedEntities
{
    [XmlRoot(ElementName = "ArticleIdList")]
    public class KeywordList
    {
        [XmlAttribute(AttributeName = "Owner")]
        public string Owner { get; set; }

        [XmlElement(ElementName = "Keyword")]
        public List<Keyword> Keywords { get; set; }
    }
}
