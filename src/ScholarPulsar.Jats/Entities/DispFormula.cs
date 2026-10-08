using System;
using System.Collections.Generic;
using System.Text;
using System.Xml.Schema;
using System.Xml;
using System.Xml.Serialization;
using ScholarPulsar.Jats.Core;

namespace ScholarPulsar.Jats.Entities
{
    [Serializable]
    [XmlRoot(ElementName = "disp-formula")]
    public class DispFormula : ParagraphElement, IXmlSerializable
    {
        [XmlAttribute(AttributeName = "id")]
        public string Id
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
            get; set;
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
