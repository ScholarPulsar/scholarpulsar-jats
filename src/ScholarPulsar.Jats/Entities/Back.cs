using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace ScholarPulsar.Jats.Entities
{
    [Serializable]
    [XmlRoot(ElementName = "back")]
    public class Back
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

        [XmlElement("p", typeof(Paragraph))]
        [XmlElement("sec", typeof(Section))]
        [XmlElement("app-group", typeof(AppendixGroup))]
        [XmlElement("notes", typeof(Notes))]
        [XmlElement("ack", typeof(Acknowledgments))]
        [XmlElement("glossary", typeof(GlossaryElements))]
        [XmlElement("bio", typeof(Biography))]
        public List<ParagraphElement> Elements
        {
            get;
            set;
        }


        [XmlElement(ElementName = "ref-list")]
        public ReferenceList ReferenceList
        {
            get; set;
        }

        [XmlElement(ElementName = "fn-group")]
        public FootnoteGroup FootnoteGroup
        {
            get; set;
        }

    }
}
