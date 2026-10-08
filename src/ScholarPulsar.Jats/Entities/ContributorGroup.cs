using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace ScholarPulsar.Jats.Entities
{
    [Serializable]
    [XmlRoot(ElementName = "contrib-group")]
    public class ContributorGroup
    {
        [XmlAttribute(AttributeName = "content-type")]
        public string ContentType
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

        [XmlElement(ElementName = "contrib")]
        public List<Contributor> Contributors
        {
            get;set;
        }

        [XmlElement(ElementName = "aff")]
        public List<Affiliation> Affs
        {
            get;
            set;
        }

        [XmlElement(ElementName = "aff-alternatives")]
        public List<AffiliationAlternatives> AffiliationAlternatives
        {
            get; set;
        }
    }
}
