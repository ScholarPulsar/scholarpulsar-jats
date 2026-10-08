using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace ScholarPulsar.Jats.Entities
{
    /// <summary>
    /// Container element for dates related to the processing history of the document (for example, received date, accepted date).
    /// </summary>
    [Serializable]
    [XmlRoot(ElementName = "history")]
    public class History
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

        [XmlElement(ElementName = "date")]
        public List<Date> Dates
        {
            get;set;
        }
    }
}
