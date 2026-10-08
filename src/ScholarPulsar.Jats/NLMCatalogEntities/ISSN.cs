using System.Xml.Serialization;
namespace ScholarPulsar.Jats.NLMCatalogEntities
{

	[XmlRoot(ElementName = "ISSN")]
	public class ISSN
	{

		[XmlAttribute(AttributeName = "IssnType")]
		//Print, Electronic
		public string IssnType { get; set; }

		[XmlText]
		public string Text { get; set; }

		[XmlAttribute(AttributeName = "ValidYN")]
		public string ValidYN { get; set; }
	}

}