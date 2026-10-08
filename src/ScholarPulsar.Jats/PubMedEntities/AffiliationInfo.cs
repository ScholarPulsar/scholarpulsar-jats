using System.Collections.Generic;
using System.Xml.Serialization;
namespace ScholarPulsar.Jats.PubMedEntities
{

	[XmlRoot(ElementName = "AffiliationInfo")]
	public class AffiliationInfo
	{

		[XmlElement(ElementName = "Affiliation")]
		public string Affiliation { get; set; }
	}

}