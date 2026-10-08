using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace ScholarPulsar.Jats.Entities
{
    [Serializable]
    [XmlRoot(ElementName = "table-wrap-foot")]
    public class TableWrapperFooter
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

        [XmlElement(ElementName = "title")]
        public Title Title
        {
            get;set;
        }

        [XmlElement(ElementName = "p")]
        public List<Paragraph> Paragraphs
        {
            get;set;
        }

        [XmlElement(ElementName = "fn")]
        public List<Footnote> Footnotes
        {
            get;set;
        }

        [XmlElement(ElementName = "fn-group")]
        public FootnoteGroup FootnoteGroup
        {
            get;set;
        }
    
    }
}
