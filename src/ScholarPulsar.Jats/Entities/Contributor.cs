using System;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace ScholarPulsar.Jats.Entities
{
    [Serializable]
    [XmlRoot(ElementName = "contrib")]
    public class Contributor
    {
        [XmlAttribute(AttributeName = "contrib-type")]
        public string ContributionType
        {
            get;set;
        }

        /// <summary>
        /// yes or no
        /// </summary>
        [XmlAttribute(AttributeName = "corresp")]
        public string CorrespondingAuthor
        {
            get;set;
        }

        /// <summary>
        /// yes or no
        /// </summary>
        [XmlAttribute(AttributeName = "deceased")]
        public string Deceased
        {
            get;set;
        }

        /// <summary>
        /// yes or no
        /// </summary>
        [XmlAttribute(AttributeName = "equal-contrib")]
        public string EqualContribution
        {
            get;set;
        }

        [XmlAttribute(AttributeName = "id")]
        public string Id
        {
            get; set;
        }

        /// <summary>
        /// Value of the identifier of an associated element; used for linking related elements (for example, <term> to a <def>, <bio> to a <contrib>).
        /// </summary>
        [XmlAttribute(AttributeName = "rid")]
        public string ReferenceToIdentifier
        {
            get;set;
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

        [XmlAttribute(AttributeName = "href", Namespace = "http://www.w3.org/1999/xlink")]
        public string Href
        {
            get; set;
        }

        [XmlElement(ElementName = "contrib-id")]
        public List<ContributorIdentifier> ContributorIds
        {
            get;set;
        }

        [XmlElement(ElementName = "name")]
        public PersonName PersonName
        {
            get;set;
        }

        [XmlElement(ElementName = "name-alternatives")]
        public NameAlternatives NameAlternatives
        {
            get;set;
        }

        [XmlElement(ElementName = "string-name")]
        public PersonStringName PersonStringName
        {
            get;set;
        }

        [XmlElement(ElementName = "collab")]
        public CollaborativeAuthor CollaborativeAuthor
        {
            get;set;
        }

        [XmlElement(ElementName = "collab-alternatives")]
        public CollaborationAlternatives CollaborationAlternatives
        {
            get;set;
        }

        [XmlElement(ElementName = "bio")]
        public Biography Biography
        {
            get;set;
        }

        [XmlElement(ElementName = "author-comment")]
        public AuthorComment AuthorComment
        {
            get;set;
        }

        [XmlElement(ElementName = "xref")]
        public List<CrossReference> Xrefs
        {
            get;
            set;
        }

        [XmlElement(ElementName = "aff")]
        public List<Affiliation> Affiliations
        {
            get;
            set;
        }

        [XmlElement(ElementName = "email")]
        public List<Email> Emails
        {
            get;set;
        }

        [XmlElement(ElementName = "uri")]
        public List<UniformResourceIdentifier> Uris
        {
            get; set;
        }

        [XmlElement(ElementName = "role")]
        public Role Role
        {
            get;
            set;
        }

        [XmlElement(ElementName = "address")]
        public Address Address
        {
            get;set;
        }
    }
}