using System;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace ScholarPulsar.Jats.Entities
{
    [Serializable]
    [XmlRoot(ElementName = "list-item")]
    public class ListWrapperItem
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
            get;set;
        }

        [XmlElement(ElementName = "title")]
        public Title Title
        {
            get;set;
        }

        [XmlElement("p", typeof(Paragraph))]
        [XmlElement("list", typeof(ListWrapper))]
        public List<ParagraphElement> Elements
        {
            get;
            set;
        }

        
    }
}