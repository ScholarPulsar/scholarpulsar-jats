using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace ScholarPulsar.Jats.Entities
{
    [Serializable]
    [XmlRoot(ElementName = "fn-group")]
    public class FootnoteGroup
    {
        [XmlElement(ElementName = "label")]
        public Label Label
        {
            get;set;
        }

        [XmlElement(ElementName = "title")]
        public Title Title
        {
            get;set;
        }

        [XmlElement(ElementName = "fn")]
        public List<Footnote> Footnotes
        {
            get;set;
        }
    }
}
