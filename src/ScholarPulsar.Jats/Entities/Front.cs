using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace ScholarPulsar.Jats.Entities
{
    [Serializable]
    [XmlRoot(ElementName = "front")]

    public class Front
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

        [XmlElement(ElementName = "journal-meta")]
        public JournalMetadata JournalMeta
        {
            get;set;
        }

        [XmlElement(ElementName = "article-meta")]
        public ArticleMetadata ArticleMeta
        {
            get;set;
        }
    }
}
