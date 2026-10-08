using ScholarPulsar.Jats.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace ScholarPulsar.Jats.Entities
{
    [Serializable]
    [XmlRoot(ElementName = "collab-alternatives")]
    public class CollaborationAlternatives : ContributorNamingElement
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

        [XmlElement(ElementName = "collab")]
        public List<CollaborativeAuthor> collaborativeAuthors
        {
            get; set;
        }
    }
}
