using System.Xml.Serialization; 
using System.Collections.Generic;
namespace ScholarPulsar.Jats.PubMedEntities
{

	[XmlRoot(ElementName = "Author")]
	public class Author
	{

		[XmlElement(ElementName = "AffiliationInfo")]
		public List<AffiliationInfo> AffiliationInfo { get; set; }

		[XmlAttribute(AttributeName = "ValidYN")]
		public string ValidYN { get; set; }

		[XmlText]
		public string Text { get; set; }

		[XmlElement(ElementName = "LastName")]
		public string LastName { get; set; }

		[XmlElement(ElementName = "ForeName")]
		public string ForeName { get; set; }

		[XmlElement(ElementName = "Initials")]
		public string Initials { get; set; }

		[XmlElement(ElementName = "Suffix")]
		public string Suffix { get; set; }

		[XmlElement(ElementName = "Identifier")]
		public List<Identifier> Identifier { get; set; }

        [XmlElement(ElementName = "CollectiveName")]
        public string CollectiveName { get; set; }


    }

}