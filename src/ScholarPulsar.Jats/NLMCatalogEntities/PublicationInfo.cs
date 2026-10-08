using System.Xml.Serialization; 
using System.Collections.Generic; 
namespace ScholarPulsar.Jats.NLMCatalogEntities{ 

[XmlRoot(ElementName="PublicationInfo")]
public class PublicationInfo { 

	[XmlElement(ElementName="Country")] 
	public string Country { get; set; } 

	[XmlElement(ElementName="PlaceCode")] 
	public PlaceCode PlaceCode { get; set; } 

	[XmlElement(ElementName="Imprint")] 
	public List<Imprint> Imprint { get; set; } 

	[XmlElement(ElementName="PublicationFirstYear")] 
	public string PublicationFirstYear { get; set; } 

	[XmlElement(ElementName="PublicationEndYear")] 
	public string PublicationEndYear { get; set; } 

	[XmlElement(ElementName="DatesOfSerialPublication")] 
	public string DatesOfSerialPublication { get; set; } 

	[XmlElement(ElementName="Frequency")] 
	public List<Frequency> Frequency { get; set; } 
}

}