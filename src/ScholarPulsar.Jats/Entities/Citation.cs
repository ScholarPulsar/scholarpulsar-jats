using ScholarPulsar.Jats.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace ScholarPulsar.Jats.Entities
{
    [Serializable]
    [XmlRoot(ElementName = "citation")]
    public class Citation : ICitation
    {
        [XmlAttribute(AttributeName = "publication-format")]
        public string PublicationFormat
        {
            get;
            set;
        }

        [XmlAttribute(AttributeName = "citation-type")]
        public string PublicationType
        {
            get;
            set;
        }

        [XmlAttribute(AttributeName = "publisher-type")]
        public string PublisherType
        {
            get;
            set;
        }

        [XmlAttribute(AttributeName = "use-type")]
        public string UseType
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

        [XmlAttribute(AttributeName = "href", Namespace = "http://www.w3.org/1999/xlink")]
        public string Href
        {
            get; set;
        }


        [XmlElement(ElementName = "article-title")]
        public ArticleTitle ArticleTitle
        {
            get; set;
        }

        [XmlElement(ElementName = "trans-title")]
        public TranslatedTitle TranslatedTitle
        {
            get; set;
        }

        [XmlElement("collab-alternatives", typeof(CollaborationAlternatives))]
        [XmlElement("collab", typeof(CollaborativeAuthor))]
        [XmlElement("name", typeof(PersonName))]
        [XmlElement("string-name", typeof(PersonStringName))]
        [XmlElement("person-group", typeof(PersonGroup))]
        public List<ContributorNamingElement> NamingElements
        {
            get;
            set;
        }

        [XmlElement(ElementName = "comment")]
        public CommentInCitation Comment
        {
            get; set;
        }

        [XmlElement(ElementName = "edition")]
        public EditionStatement Edition
        {
            get; set;
        }

        [XmlElement(ElementName = "elocation-id")]
        public ElectronicLocationIdentifier ELocationId
        {
            get; set;
        }

        [XmlElement(ElementName = "fpage")]
        public FirstPage FirstPage
        {
            get; set;
        }

        [XmlElement(ElementName = "lpage")]
        public LastPage LastPage
        {
            get; set;
        }

        [XmlElement(ElementName = "page-range")]
        public PageRanges PageRanges
        {
            get; set;
        }

        [XmlElement(ElementName = "source")]
        public Source Source
        {
            get; set;
        }

        [XmlElement(ElementName = "year")]
        public Year Year
        {
            get; set;
        }

        [XmlElement(ElementName = "month")]
        public Month Month
        {
            get; set;
        }

        [XmlElement(ElementName = "day")]
        public Day Day
        {
            get; set;
        }

        [XmlElement(ElementName = "volume")]
        public VolumeNumber Volume
        {
            get; set;
        }

        [XmlElement(ElementName = "issue")]
        public IssueNumber Issue
        {
            get; set;
        }

        [XmlElement(ElementName = "publisher-name")]
        public List<PublisherName> PublisherNames
        {
            get; set;
        }

        [XmlElement(ElementName = "publisher-loc")]
        public List<PublisherLocation> PublisherLocations
        {
            get; set;
        }

        [XmlElement(ElementName = "supplement")]
        public SupplementInformation Supplement
        {
            get; set;
        }

        [XmlElement(ElementName = "pub-id")]
        public List<PublicationIdentifier> PubIds
        {
            get; set;
        }

        [XmlElement(ElementName = "access-date")]
        public AccessDate AccessDate
        {
            get; set;
        }

        [XmlElement(ElementName = "conf-date")]
        public ConferenceDate ConferenceDate
        {
            get; set;
        }

        [XmlElement(ElementName = "conf-name")]
        public ConferenceName ConferenceName
        {
            get; set;
        }

        [XmlElement(ElementName = "conf-loc")]
        public ConferenceLocation ConferenceLocation
        {
            get; set;
        }
    }
}
