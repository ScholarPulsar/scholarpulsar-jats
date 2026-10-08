using System.Xml.Serialization; 
using System.Collections.Generic; 
namespace ScholarPulsar.Jats.NLMCatalogEntities{ 

[XmlRoot(ElementName="ELocationList")]
public class ELocationList { 

	[XmlElement(ElementName="ELocation")] 
	public List<ELocation> ELocation { get; set; } 
}

}