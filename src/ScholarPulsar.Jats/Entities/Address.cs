using System;
using System.Collections.Generic;
using System.Text;
using System.Xml.Serialization;

namespace ScholarPulsar.Jats.Entities
{
    [Serializable]
    [XmlRoot(ElementName = "abstract")]
    public class Address
    {
        [XmlElement(ElementName = "email")]
        public Email Email
        {
            get; set;
        }

        [XmlElement(ElementName = "phone")]
        public PhoneNumber PhoneNumber
        {
            get; set;
        }
    }
}
