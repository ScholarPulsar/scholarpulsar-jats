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
    public class InnerXmlElement : IXmlSerializable
    {
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
