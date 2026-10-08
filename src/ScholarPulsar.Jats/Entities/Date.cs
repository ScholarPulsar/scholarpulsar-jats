using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace ScholarPulsar.Jats.Entities
{
    [Serializable]
    [XmlRoot(ElementName = "date")]

    public class Date
    {
        [XmlAttribute(AttributeName = "calendar")]
        public string Calendar
        {
            get; set;
        }

        [XmlAttribute(AttributeName = "date-type")]
        public string DateType
        {
            get; set;
        }

        [XmlAttribute(AttributeName = "id")]
        public string Id
        {
            get; set;
        }

        [XmlAttribute(AttributeName = "iso-8601-date")]
        public string Iso8601date
        {
            get; set;
        }

        [XmlAttribute(AttributeName = "publication-format")]
        public string PublicationFormat
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

        [XmlElement(ElementName = "day")]
        public Day Day
        {
            get; set;
        }

        [XmlElement(ElementName = "month")]
        public Month Month
        {
            get; set;
        }

        [XmlElement(ElementName = "year")]
        public Year Year
        {
            get; set;
        }
    }
}
