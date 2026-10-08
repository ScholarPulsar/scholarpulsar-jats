using System.Xml.Serialization; 
using System.Collections.Generic; 
namespace ScholarPulsar.Jats.PubMedEntities{ 

[XmlRoot(ElementName="ReferenceList")]
public class ReferenceList { 

	[XmlElement(ElementName="Reference")] 
	public List<Reference> Reference { get; set; } 
}

}