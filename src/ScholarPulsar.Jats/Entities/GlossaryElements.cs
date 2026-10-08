using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace ScholarPulsar.Jats.Entities
{
    [Serializable]
    [XmlRoot(ElementName = "glossary")]
    public class GlossaryElements : ParagraphElement
    {
        [XmlAttribute(AttributeName = "id")]
        public string Id
        {
            get;
            set;
        }

        [XmlElement(ElementName = "label")]
        public Label Label
        {
            get; set;
        }

        [XmlElement(ElementName = "title")]
        public Title Title
        {
            get; set;
        }

        [XmlElement(ElementName = "def-list")]
        public List<DefinitionList> DefinitionLists
        {
            get; set;
        }

        [XmlElement(ElementName = "table-wrap")]
        public TableWrapper TableWrapper
        {
            get; set;
        }

        [XmlElement(ElementName = "p")]
        public List<Paragraph> Paragraphs
        {
            get; set;
        }
    }
}
