using System.Xml.Serialization; 
using System.Collections.Generic;
namespace ScholarPulsar.Jats.PubMedEntities
{

	[XmlRoot(ElementName = "InvestigatorList")]
	public class InvestigatorList
	{

		[XmlElement(ElementName = "Investigator")]
		public List<Investigator> Investigators { get; set; }


		[XmlText]
		public string Text { get; set; }
	}

}