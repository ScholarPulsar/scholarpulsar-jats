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
    [XmlRoot(ElementName = "p")]
    public class Paragraph: ParagraphElement, IXmlSerializable
    {
        [XmlAttribute(AttributeName = "id")]
        public string Id
        {
            get; set;
        }

        [XmlAttribute(AttributeName = "cotent-type")]
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

        [XmlText]
        public string Content
        {
            get; set;
        }

        public string InnerXml
        {
            get;set;
        }

        public XmlSchema GetSchema()
        {
            return null;
        }

        public void ReadXml(XmlReader reader)
        {
            JATSHelper.InitAttribute(reader, this);
            this.InnerXml = reader.ReadInnerXml();
        }

        public void WriteXml(XmlWriter writer)
        {
            
        }
    }
}
