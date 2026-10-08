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
    [XmlRoot(ElementName = "collab")]
    public class CollaborativeAuthor: ContributorNamingElement, IXmlSerializable
    {
        [XmlAttribute(AttributeName = "collab-type")]
        public string CollaborationType
        {
            get; set;
        }

        [XmlAttribute(AttributeName = "specific-use")]
        public string SpecificUse
        {
            get; set;
        }

        [XmlAttribute(AttributeName = "id")]
        public string Id
        {
            get; set;
        }

        /// <summary>
        /// Stores the symbol (for example, an asterisk, numeral, section mark) that was displayed in the original document to identify a specific footnote, if this symbol is to be preserved.
        /// </summary>
        [XmlAttribute(AttributeName = "symbol")]
        public string Symbol
        {
            get;set;
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

        [XmlAttribute(AttributeName = "href", Namespace = "http://www.w3.org/1999/xlink")]
        public string Href
        {
            get; set;
        }

        [XmlAttribute(AttributeName = "xlink", Namespace = "http://www.w3.org/2000/xlink/xmlns")]
        public string XLinkNamespaceDeclaration
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
