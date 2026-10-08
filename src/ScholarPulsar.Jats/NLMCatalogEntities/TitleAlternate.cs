using System.Collections.Generic;
using System.Xml.Serialization;
namespace ScholarPulsar.Jats.NLMCatalogEntities
{

	[XmlRoot(ElementName = "TitleAlternate")]
	public class TitleAlternate
	{

		[XmlElement(ElementName = "Title")]
		public List<Title> Titles { get; set; }

		[XmlAttribute(AttributeName = "Owner")]
		public string Owner { get; set; }

		[XmlAttribute(AttributeName = "TitleType")]
		public string TitleType { get; set; }

		[XmlText]
		public string Text { get; set; }
	}

}