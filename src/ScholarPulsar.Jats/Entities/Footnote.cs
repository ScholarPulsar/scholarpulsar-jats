using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace ScholarPulsar.Jats.Entities
{
    [Serializable]
    [XmlRoot(ElementName = "fn")]
    public class Footnote
    {
        [XmlAttribute(AttributeName = "fn-type")]
        public string FootnoteType
        {
            get; set;
        }

        [XmlAttribute(AttributeName = "specific-use")]
        public string SpecificUse
        {
            get; set;
        }

        [XmlAttribute(AttributeName = "id")]
        public string Id
        {
            get; set;
        }

        /// <summary>
        /// Stores the symbol (for example, an asterisk, numeral, section mark) that was displayed in the original document to identify a specific footnote, if this symbol is to be preserved.
        /// </summary>
        [XmlAttribute(AttributeName = "symbol")]
        public string Symbol
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

        [XmlElement(ElementName = "label")]
        public Label Label
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
