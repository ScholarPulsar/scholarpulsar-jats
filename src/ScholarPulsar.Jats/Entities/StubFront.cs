using System;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace ScholarPulsar.Jats.Entities
{
    [Serializable]
    [XmlRoot(ElementName = "sub-article")]
    public class StubFront
    {
        [XmlAttribute(AttributeName = "id")]
        public string Id
        {
            get;
            set;
        }

        [XmlAttribute(AttributeName = "base", Namespace = "http://www.w3.org/xml/1998/namespace")]
        public string Base
        {
            get; set;
        }

        [XmlElement(ElementName = "article-id")]
        public List<ArticleIdentifier> ArticleIds
        {
            get;set;
        }

        [XmlElement(ElementName = "article-categories")]
        public ArticleGroupingData ArticleCategories
        {
            get;set;
        }

        [XmlElement(ElementName = "title-group")]
        public TitleGroup TitleGroup
        {
            get;set;
        }

        [XmlElement(ElementName = "contrib-group")]
        public ContributorGroup ConGroup
        {
            get;
            set;
        }

        [XmlElement(ElementName = "aff")]
        public List<Affiliation> Affs
        {
            get;
            set;
        }

        [XmlElement(ElementName = "pub-date")]
        public List<PublicationDate> PubDates
        {
            get;
            set;
        }

        [XmlElement(ElementName = "volume")]
        public string Volume
        {
            get;
            set;
        }

        [XmlElement(ElementName = "issue")]
        public string Issue
        {
            get;
            set;
        }

        [XmlElement(ElementName = "fpage")]
        public string FirstPage
        {
            get;
            set;
        }

        [XmlElement(ElementName = "lpage")]
        public string LastPage
        {
            get;
            set;
        }

        [XmlElement(ElementName = "elocation-id")]
        public string ElectronicLocationIdentifier
        {
            get; set;
        }

        public History History
        {
            get;
            set;
        }

        public Permissions Permissions
        {
            get;
            set;
        }

        public Abstract Abstract
        {
            get;
            set;
        }

        public KeywordGroup Keywords
        {
            get;
            set;
        }
    }
}