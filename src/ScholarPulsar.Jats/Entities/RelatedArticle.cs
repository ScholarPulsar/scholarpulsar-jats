using System;
using System.Collections.Generic;
using System.Text;
using System.Xml.Serialization;

namespace ScholarPulsar.Jats.Entities
{
    [Serializable]
    [XmlRoot(ElementName = "related-article")]
    public class RelatedArticle : InnerXmlElement
    {
        [XmlAttribute(AttributeName = "related-article-type")]
        public string RelatedArticleType
        {
            get; set;
        }

        [XmlAttribute(AttributeName = "id")]
        public string Id
        {
            get; set;
        }


        [XmlAttribute(AttributeName = "href", Namespace = "http://www.w3.org/1999/xlink")]
        public string Href
        {
            get; set;
        }

        [XmlAttribute(AttributeName = "ext-link-type")]
        public string ExternalLinkType
        {
            get; set;
        }
    }
}
