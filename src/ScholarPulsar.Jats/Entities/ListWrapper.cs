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
    [XmlRoot(ElementName = "list")]
    public class ListWrapper : ParagraphElement
    {
        [XmlAttribute(AttributeName = "id")]
        public string Id
        {
            get;
            set;
        }

        [XmlAttribute(AttributeName = "list-type")]
        public string ListType
        {
            get;
            set;
        }

        [XmlElement("list-item")]
        public List<ListWrapperItem> Items
        {
            get; set;
        }
    }
}
