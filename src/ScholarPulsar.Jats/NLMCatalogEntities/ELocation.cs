using System.Collections.Generic;
using System.Xml.Serialization;
namespace ScholarPulsar.Jats.NLMCatalogEntities
{

	[XmlRoot(ElementName = "ELocation")]
	public class ELocation
	{

		[XmlElement(ElementName = "ELocationID")]
		public List<ELocationID> ELocationIDs { get; set; }
	}

}