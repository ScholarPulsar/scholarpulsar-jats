using System;
using System.Collections.Generic;
using System.Text;
using System.Xml.Serialization;

namespace ScholarPulsar.Jats.PubMedEntities
{
    [XmlRoot(ElementName = "BookDocument")]
    public class BookDocument
    {
        [XmlElement(ElementName = "PMID")]
        public PMID PMID { get; set; }

        [XmlElement(ElementName = "ArticleIdList")]
        public ArticleIdList ArticleIdList { get; set; }

        [XmlElement(ElementName = "Book")]
        public Book Book { get; set; }

        [XmlElement(ElementName = "AuthorList")]
        public AuthorList AuthorList { get; set; }

        [XmlElement(ElementName = "ArticleTitle")]
        public ArticleTitle ArticleTitle { get; set; }

        [XmlElement(ElementName = "Language")]
        public string Language { get; set; }

        [XmlElement(ElementName = "PublicationType")]
        public PublicationType PublicationType { get; set; }

        [XmlElement(ElementName = "Abstract")]
        public Abstract Abstract { get; set; }

        public ContributionDate ContributionDate { get; set; }
    }
}
