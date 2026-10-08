using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace ScholarPulsar.Jats.Entities
{
    [Serializable]
    [XmlRoot(ElementName = "article-meta")]
    public class ArticleMetadata
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

        [XmlElement(ElementName = "article-id")]
        public List<ArticleIdentifier> ArticleIdentifiers
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
        public ContributorGroup ContributorGroup
        {
            get;set;
        }

        [XmlElement(ElementName = "aff")]
        public List<Affiliation> Affiliations
        {
            get;set;
        }

        [XmlElement(ElementName = "author-notes")]
        public AuthorNoteGroup AuthorNotes
        {
            get;set;
        }

        [XmlElement(ElementName = "pub-date")]
        public List<PublicationDate> PublicationDates
        {
            get;set;
        }

        [XmlElement(ElementName = "volume")]
        public List<VolumeNumber> Volumes
        {
            get;set;
        }

        [XmlElement(ElementName = "issue")]
        public List<IssueNumber> Issues
        {
            get; set;
        }

        [XmlElement(ElementName = "elocation-id")]
        public ElectronicLocationIdentifier ELocationId
        {
            get;set;
        }

        [XmlElement(ElementName = "permissions")]
        public Permissions Permissions
        {
            get;set;
        }

        [XmlElement(ElementName = "related-article")]
        public List<RelatedArticle> RelatedArticles
        {
            get; set;
        }

        [XmlElement(ElementName = "abstract")]
        public List<Abstract> Abstracts
        {
            get;set;
        }

        [XmlElement(ElementName = "kwd-group")]
        public List<KeywordGroup> keywordGroups
        {
            get;set;
        }

        [XmlElement(ElementName = "history")]
        public History History
        {
            get;set;
        }

        [XmlElement(ElementName = "funding-group")]
        public List<FundingGroup> FundingGroups
        {
            get;set;
        }

        public SupplementInformation Supplement
        {
            get;set;
        }

        [XmlElement(ElementName = "fpage")]
        public FirstPage FirstPage
        {
            get;set;
        }

        [XmlElement(ElementName = "lpage")]
        public LastPage LastPage
        {
            get;set;
        }

        [XmlElement(ElementName = "self-uri")]
        public List<SelfUri> SelfUris
        {
            get; set;
        }
    }
}
