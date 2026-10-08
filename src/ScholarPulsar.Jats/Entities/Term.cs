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
    [XmlRoot(ElementName = "term")]
    public class Term : InnerXmlElement
    {
        [XmlAttribute(AttributeName = "id")]
        public string Id
        {
            get;
            set;
        }

        [XmlAttribute(AttributeName = "term-status")]
        public string TermStatus
        {
            get;
            set;
        }

        [XmlAttribute(AttributeName = "term-type")]
        public string TermType
        {
            get;
            set;
        }
    }
}
