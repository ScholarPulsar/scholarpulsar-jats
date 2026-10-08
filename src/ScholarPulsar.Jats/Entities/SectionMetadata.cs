using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace ScholarPulsar.Jats.Entities
{
    /// <summary>
    /// Container element for section-level metadata that is different from the parent document.
    /// </summary>
    [Serializable]
    [XmlRoot(ElementName = "sec-meta")]

    public class SectionMetadata
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

        [XmlElement(ElementName = "contrib-group")]
        public List<ContributorGroup> ContributorGroups
        {
            get;set;
        }
    }
}
