using System;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace ScholarPulsar.Jats.Entities
{
    [Serializable]
    [XmlRoot(ElementName = "sub-article")]
    public class SubArticle
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

        public Front Front
        {
            get;
            set;
        }

        public StubFront StubFront
        {
            get;
            set;
        }

        public Body Body
        {
            get;
            set;
        }

        public Back Back
        {
            get;
            set;
        }

        [XmlElement(ElementName = "sub-article")]
        public List<SubArticle> SubArticles
        {
            get;
            set;
        }

    }
}