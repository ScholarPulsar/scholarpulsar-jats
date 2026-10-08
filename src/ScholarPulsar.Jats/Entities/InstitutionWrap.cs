using System.Xml.Serialization;
using System;
using System.Collections.Generic;

namespace ScholarPulsar.Jats.Entities
{
    [Serializable]
    [XmlRoot(ElementName = "institution-wrap")]
    public class InstitutionWrap
    {
        [XmlElement(ElementName = "institution")]
        public List<Institution> Institutions { get; set; }

        [XmlElement(ElementName = "institution-id")]
        public List<InstitutionId> InstitutionIds { get; set; }
    }
}