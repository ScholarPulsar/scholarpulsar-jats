using System.Xml.Serialization; 
namespace ScholarPulsar.Jats.NLMCatalogEntities{ 

[XmlRoot(ElementName="LCCN")]
public class LCCN { 

	[XmlAttribute(AttributeName="ValidYN")] 
	public string ValidYN { get; set; } 

	[XmlText] 
	public string Text { get; set; } 
}

}