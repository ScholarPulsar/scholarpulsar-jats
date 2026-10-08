using System;
using System.Collections.Generic;
using System.Text;
using System.Xml.Serialization;

namespace ScholarPulsar.Jats.Entities
{
    [Serializable]
    [XmlRoot(ElementName = "app-group")]
    public class AppendixGroup : ParagraphElement
    {
        [XmlAttribute(AttributeName = "id")]
        public string Id
        {
            get; set;
        }

        [XmlElement(ElementName = "app")]
        public List<Appendix> Appendices { get; set; }
    }
}
