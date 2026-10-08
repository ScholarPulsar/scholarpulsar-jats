using System.Xml.Serialization; 
namespace ScholarPulsar.Jats.NLMCatalogEntities{ 

[XmlRoot(ElementName="ISSNLinking")]
public class ISSNLinking { 

	[XmlAttribute(AttributeName="ValidYN")] 
	public string ValidYN { get; set; } 

	[XmlText] 
	public string Text { get; set; } 
}

}