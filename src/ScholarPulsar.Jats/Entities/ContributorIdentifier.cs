using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace ScholarPulsar.Jats.Entities
{
    [Serializable]
    [XmlRoot(ElementName = "contrib-id")]
    public class ContributorIdentifier : InnerXmlElement
    {
        [XmlAttribute(AttributeName = "assigning-authority")]
        public string AssigningAuthority
        {
            get; set;
        }

        /// <summary>
        /// true or false
        /// true	This contributor identifier has been marked by the issuing authority as authenticated.
        /// false	No guarantee has been made about this contributor identifier.
        /// </summary>
        [XmlAttribute(AttributeName = "authenticated")]
        public string Authenticated
        {
            get;set;
        }

        [XmlAttribute(AttributeName = "content-type")]
        public string ContentType
        {
            get; set;
        }

        /// <summary>
        /// The type of contributor identifier or the authority (such as a publisher or industry organization) that is responsible for the creation of the contributor identifier, for example, “ORCID” or “JST”.
        /// </summary>
        [XmlAttribute(AttributeName = "contrib-id-type")]
        public string ContributorIdentifierType
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
