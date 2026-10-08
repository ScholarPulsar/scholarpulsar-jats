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
    [XmlRoot(ElementName = "table-wrap")]
    public class TableWrapper: ParagraphElement
    {
        [XmlAttribute(AttributeName = "id")]
        public string Id
        {
            get; set;
        }

        /// <summary>
        /// Indicates whether an object (for example, a figure or table) should be positioned in a tall manner with the long edge vertical (“portrait”) or in a wide manner with the long edge horizontal (“landscape”).
        /// </summary>
        [XmlAttribute(AttributeName = "orientation")]
        public string Orientation
        {
            get; set;
        }

        [XmlAttribute(AttributeName = "position")]
        public string Position
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

        [XmlElement(ElementName = "object-id")]
        public List<ObjectIdentifier> ObjectIds
        {
            get; set;
        }

        [XmlElement(ElementName = "label")]
        public Label Label
        {
            get; set;
        }

        [XmlElement(ElementName = "caption")]
        public Caption Caption
        {
            get; set;
        }

        [XmlElement(ElementName = "graphic")]
        public List<Graphic> Graphics
        {
            get; set;
        }

        [XmlElement(ElementName = "table")]
        public Table Table
        {
            get;set;
        }

        [XmlElement(ElementName = "table-wrap-foot")]
        public TableWrapperFooter Footer
        {
            get;set;
        }
    }
}
