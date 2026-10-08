using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace ScholarPulsar.Jats.Entities
{
    [Serializable]
    [XmlRoot(ElementName = "title-group")]
    public class TitleGroup
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

        [XmlElement(ElementName = "article-title")]
        public ArticleTitle ArticleTitle
        {
            get;set;
        }

        [XmlElement(ElementName = "alt-title")]
        public List<AlternateTitle> AlternateTitles
        {
            get;set;
        }
    }
}
