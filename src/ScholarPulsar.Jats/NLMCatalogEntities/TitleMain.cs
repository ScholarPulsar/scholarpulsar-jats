using System.Collections.Generic;
using System.Xml.Serialization;
namespace ScholarPulsar.Jats.NLMCatalogEntities
{

	[XmlRoot(ElementName = "TitleMain")]
	public class TitleMain
	{

		[XmlElement(ElementName = "Title")]
		public List<Title> Titles { get; set; }
	}

}