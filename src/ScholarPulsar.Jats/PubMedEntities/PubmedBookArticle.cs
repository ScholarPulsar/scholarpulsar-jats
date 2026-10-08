using System;
using System.Collections.Generic;
using System.Text;
using System.Xml.Serialization;

namespace ScholarPulsar.Jats.PubMedEntities
{
    [XmlRoot(ElementName = "PubmedBookArticle")]
    public class PubmedBookArticle
    {
        [XmlElement(ElementName = "BookDocument")]
        public BookDocument BookDocument { get; set; }
    }
}
