using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace ScholarPulsar.Jats.Entities
{
    [Serializable]
    [XmlRoot(ElementName = "journal-meta")]
    public class JournalMetadata
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

        [XmlElement(ElementName = "journal-id")]
        public List<JournalIdentifier> JournalIds
        {
            get;set;
        }

        [XmlElement(ElementName = "journal-title-group")]
        public List<JournalTitleGroup> TitleGroups
        {
            get;set;
        }

        [XmlElement(ElementName = "journal-title")]
        public List<JournalTitle> JournalTitles
        {
            get;set;
        }

        [XmlElement(ElementName = "abbrev-journal-title")]
        public List<AbbreviatedJournalTitle> AbbrevJournalTitles
        {
            get;set;
        }

        [XmlElement(ElementName = "issn")]
        public List<ISSN> ISSNs
        {
            get;set;
        }

        [XmlElement(ElementName = "isbn")]
        public List<ISBN> ISBNs
        {
            get; set;
        }

        [XmlElement(ElementName = "publisher")]
        public List<Publisher> Publishers
        {
            get;set;
        }
    }
}
