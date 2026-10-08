using System.Xml.Serialization; 
namespace ScholarPulsar.Jats.PubMedEntities{ 

[XmlRoot(ElementName="PubmedArticle")]
public class PubmedArticle { 

	[XmlElement(ElementName="MedlineCitation")] 
	public MedlineCitation MedlineCitation { get; set; } 

	[XmlElement(ElementName="PubmedData")] 
	public PubmedData PubmedData { get; set; } 
}

}