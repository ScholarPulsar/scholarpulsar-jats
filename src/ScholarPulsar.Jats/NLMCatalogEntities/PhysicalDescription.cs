using System.Xml.Serialization; 
namespace ScholarPulsar.Jats.NLMCatalogEntities{ 

[XmlRoot(ElementName="PhysicalDescription")]
public class PhysicalDescription { 

	[XmlElement(ElementName="Extent")] 
	public string Extent { get; set; } 
}

}