using ScholarPulsar.Jats.Base;
using ScholarPulsar.Jats.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Schema;
using System.Xml.Serialization;

namespace ScholarPulsar.Jats.Entities
{
    [Serializable]
    [XmlRoot(ElementName = "body")]
    public class Body
    {

        [XmlAttribute(AttributeName = "id")]
        public string Id
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

        [XmlElement("sec",typeof(Section))]
        [XmlElement("p", typeof(Paragraph))]
        [XmlElement("boxed-text", typeof(BoxedText))]
        [XmlElement("list", typeof(ListWrapper))]
        [XmlElement("fig", typeof(Figure))]
        [XmlElement("fig-group", typeof(FigureGroup))]
        [XmlElement("table-wrap", typeof(TableWrapper))]
        [XmlElement("table-wrap-group", typeof(TableWrapperGroup))]
        public List<ParagraphElement> Elements
        {
            get;
            set;
        }
    }
}
