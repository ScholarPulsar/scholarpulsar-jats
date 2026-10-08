using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace ScholarPulsar.Jats.Entities
{
    [Serializable]
    [XmlRoot(ElementName = "subj-group")]
    public class SubjectGroup
    {
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

        [XmlAttribute(AttributeName = "lang", Namespace = "http://www.w3.org/xml/1998/namespace")]
        public string Language
        {
            get; set;
        }

        [XmlAttribute(AttributeName = "subj-group-type")]
        public string SubjectGroupType
        {
            get;set;
        }

        [XmlElement(ElementName = "subject")]
        public List<SubjectGroupingName> Subjects
        {
            get;set;
        }

    }
}
