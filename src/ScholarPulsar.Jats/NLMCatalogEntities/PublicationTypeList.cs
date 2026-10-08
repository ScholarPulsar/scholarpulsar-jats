using System.Xml.Serialization; 
using System.Collections.Generic;
namespace ScholarPulsar.Jats.NLMCatalogEntities
{

	[XmlRoot(ElementName = "PublicationTypeList")]
	public class PublicationTypeList
	{

		[XmlElement(ElementName = "PublicationType")]
		public List<PublicationType> PublicationTypes { get; set; }
	}

}