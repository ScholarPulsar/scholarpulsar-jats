using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace ScholarPulsar.Jats.Entities
{
    [Serializable]
    [XmlRoot(ElementName = "def-list")]
    public class DefinitionList
    {
        [XmlElement(ElementName = "label")]
        public Label Label
        {
            get; set;
        }

        [XmlElement(ElementName = "title")]
        public Title Title
        {
            get; set;
        }

        [XmlElement(ElementName = "def-head")]
        public DefinitionHead DefinitionHead
        {
            get;set;
        }

        [XmlElement(ElementName = "term-head")]
        public TermHead TermHead
        {
            get; set;
        }

        [XmlElement(ElementName = "def-item")]
        public List<DefinitionItem> DefItems
        {
            get;
            set;
        }
    }
}
