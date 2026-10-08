using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace ScholarPulsar.Jats.Entities
{
    [Serializable]
    [XmlRoot(ElementName = "journal-title-group")]
    public class JournalTitleGroup
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

        [XmlAttribute(AttributeName = "content-type")]
        public string ContentType
        {
            get; set;
        }

        [XmlElement(ElementName = "journal-title")]
        public List<JournalTitle> Titles
        {
            get;set;
        }

        [XmlElement(ElementName = "journal-subtitle")]
        public List<JournalSubtitle> SubTitles
        {
            get; set;
        }

        [XmlElement(ElementName = "abbrev-journal-title")]
        public List<AbbreviatedJournalTitle> AbbrTitles
        {
            get; set;
        }
    }
}
