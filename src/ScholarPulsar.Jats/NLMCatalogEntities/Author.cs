using System.Xml.Serialization; 
using System.Collections.Generic; 
namespace ScholarPulsar.Jats.NLMCatalogEntities{ 

[XmlRoot(ElementName="Author")]
public class Author { 

	[XmlElement(ElementName="CollectiveName")] 
	public string CollectiveName { get; set; } 

	[XmlElement(ElementName="Identifier")] 
	public List<Identifier> Identifier { get; set; } 
}

}