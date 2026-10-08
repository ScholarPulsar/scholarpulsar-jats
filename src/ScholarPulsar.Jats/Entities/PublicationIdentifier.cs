using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace ScholarPulsar.Jats.Entities
{
    [Serializable]
    [XmlRoot(ElementName = "pub-id")]
    public class PublicationIdentifier : InnerXmlElement
    {


        [XmlAttribute(AttributeName = "pub-id-type")]
        public string PublicationIdentifierType
        {
            get; set;
        }

        [XmlAttribute(AttributeName = "assigning-authority")]
        public string AssigningAuthority
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


        [XmlAttribute(AttributeName = "base", Namespace = "http://www.w3.org/xml/1998/namespace")]
        public string Base
        {
            get; set;
        }
    }
}
