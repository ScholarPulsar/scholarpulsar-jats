using ScholarPulsar.Jats.Entities;
using System;
using System.Collections.Generic;
using System.Text;
using System.Xml.Serialization;

namespace ScholarPulsar.Jats.PubMedEntities
{
    [XmlRoot(ElementName = "CopyrightInformation")]
    public class CopyrightInformation : InnerXmlElement
    {
    }
}
