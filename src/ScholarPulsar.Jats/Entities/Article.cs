using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace ScholarPulsar.Jats.Entities
{
    [Serializable]
    [XmlRoot(ElementName = "article")]
    public class Article
    {
        [XmlAttribute(AttributeName = "id")]
        public string Id
        {
            get;
            set;
        }

        [XmlAttribute(AttributeName = "article-type")]
        public string Type
        {
            get;
            set;
        }

        [XmlAttribute(AttributeName = "dtd-version")]
        public string TagSetVersion
        {
            get;
            set;
        }

        [XmlAttribute(AttributeName = "lang", Namespace = "http://www.w3.org/xml/1998/namespace")]
        public string Language
        {
            get;
            set;
        }

        [XmlAttribute(AttributeName = "xlink", Namespace = "http://www.w3.org/2000/xlink/xmlns")]
        public string XLinkNamespace
        {
            get;
            set;
        }

        [XmlAttribute(AttributeName = "xsi", Namespace = "http://www.w3.org/2000/xlink/xmlns")]
        public string XMLSchemaNamespace
        {
            get;
            set;
        }

        [XmlElement(ElementName = "front")]
        public Front Front
        {
            get;
            set;
        }

        [XmlElement(ElementName = "body")]
        public Body Body
        {
            get;
            set;
        }

        [XmlElement(ElementName = "back")]
        public Back Back
        {
            get;
            set;
        }

        [XmlElement(ElementName = "sub-article")]
        public List<SubArticle> SubArticles
        {
            get; set;
        }
    }
}
