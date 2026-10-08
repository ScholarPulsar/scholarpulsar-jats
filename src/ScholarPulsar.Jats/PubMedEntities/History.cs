using System.Xml.Serialization; 
using System.Collections.Generic; 
namespace ScholarPulsar.Jats.PubMedEntities{ 

[XmlRoot(ElementName="History")]
public class History { 

	[XmlElement(ElementName="PubMedPubDate")] 
	public List<PubMedPubDate> PubMedPubDate { get; set; } 
}

}