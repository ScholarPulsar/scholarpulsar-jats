using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace ScholarPulsar.Jats.Entities
{
    [Serializable]
    [XmlRoot(ElementName = "permissions")]
    public class Permissions
    {
        [XmlAttribute(AttributeName = "id")]
        public string Id
        {
            get; set;
        }

        [XmlAttribute(AttributeName = "base", Namespace = "http://www.w3.org/xml/1998/namespace")]
        public string Base
        {
            get; set;
        }

        [XmlElement(ElementName = "copyright-statement")]
        public CopyrightStatement CopyrightStatement
        {
            get;set;
        }

        [XmlElement(ElementName = "copyright-year")]
        public CopyrightYear CopyrightYear
        {
            get; set;
        }

        [XmlElement(ElementName = "copyright-holder")]
        public CopyrightHolder CopyrightHolder
        {
            get; set;
        }

        [XmlElement(ElementName = "license")]
        public License License
        {
            get;set;
        }
    }
}
