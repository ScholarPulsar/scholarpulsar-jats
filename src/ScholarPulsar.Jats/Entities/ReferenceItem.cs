using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace ScholarPulsar.Jats.Entities
{
    [Serializable]
    [XmlRoot(ElementName = "ref")]
    public class ReferenceItem
    {
        [XmlAttribute(AttributeName = "id")]
        public string Id
        {
            get; set;
        }

        [XmlAttribute(AttributeName = "content-type")]
        public string ContentType
        {
            get; set;
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

        [XmlElement(ElementName = "element-citation")]
        public ElementCitation ElementCitation
        {
            get;
            set;
        }

        [XmlElement(ElementName = "nlm-citation")]
        
        public NLMCitation NLMCitation
        {
            get;
            set;
        }

        [XmlElement(ElementName = "citation")]
        public Citation Citation
        {
            get;set;
        }

        [XmlElement(ElementName = "mixed-citation")]
        public MixedCitation MixedCitation
        {
            get; set;
        }
    }
}
