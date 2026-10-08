using System;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace ScholarPulsar.Jats.Entities
{
    [Serializable]
    [XmlRoot(ElementName = "def")]
    public class Definition
    {
        [XmlElement(ElementName = "p")]
        public List<Paragraph> Paragraphs
        {
            get;set;
        }
    }
}