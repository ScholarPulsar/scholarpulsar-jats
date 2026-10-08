using System.Xml.Serialization; 
using System.Collections.Generic; 
namespace ScholarPulsar.Jats.NLMCatalogEntities{ 

[XmlRoot(ElementName="ResourceInfo")]
public class ResourceInfo { 

	[XmlElement(ElementName="TypeOfResource")] 
	public string TypeOfResource { get; set; } 

	[XmlElement(ElementName="Issuance")] 
	public string Issuance { get; set; } 

	[XmlElement(ElementName="ResourceUnit")] 
	public List<string> ResourceUnit { get; set; } 

	[XmlElement(ElementName="Resource")] 
	public Resource Resource { get; set; } 
}

}