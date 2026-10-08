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
    [XmlRoot(ElementName = "disp-quote")]
    public class QuoteDisplayed: ParagraphElement
    {
        [XmlAttribute(AttributeName = "id")]
        public string Id
        {
            get;
            set;
        }

        [XmlAttribute(AttributeName = "content-type")]
        public string ContentType
        {
            get;
            set;
        }

        [XmlAttribute(AttributeName = "xml:lang")]
        public string Language
        {
            get;
            set;
        }

        [XmlElement(ElementName = "p")]
        public List<Paragraph> Paragraphs
        {
            get; set;
        }
    }
}
