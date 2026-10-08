using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace ScholarPulsar.Jats.Entities
{
    [Serializable]
    [XmlRoot(ElementName = "table")]
    public class Table : InnerXmlElement
    {
        [XmlAttribute(AttributeName = "id")]
        public string Id
        {
            get; set;
        }

        [XmlAttribute(AttributeName = "boarder")]
        public string Border
        {
            get; set;
        }

        [XmlAttribute(AttributeName = "cellpadding")]
        public string CellPadding
        {
            get; set;
        }

        [XmlAttribute(AttributeName = "cellspacing")]
        public string CellSpacing
        {
            get; set;
        }

        [XmlAttribute(AttributeName = "frame")]
        public string Frame
        {
            get; set;
        }

        [XmlAttribute(AttributeName = "rules")]
        public string Rules
        {
            get; set;
        }

        [XmlAttribute(AttributeName = "style")]
        public string Style
        {
            get; set;
        }

        [XmlAttribute(AttributeName = "width")]
        public string Width
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


    }
}
