using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace ScholarPulsar.Jats.Entities
{
    [Serializable]
    [XmlRoot(ElementName = "article-categories")]
    public class ArticleGroupingData
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

        [XmlElement(ElementName = "subj-group")]
        public List<SubjectGroup> SubjectGroups
        {
            get;set;
        }
    }
}
