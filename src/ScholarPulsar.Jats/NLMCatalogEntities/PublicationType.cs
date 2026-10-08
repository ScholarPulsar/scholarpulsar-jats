using System.Xml.Serialization; 
namespace ScholarPulsar.Jats.NLMCatalogEntities{ 

[XmlRoot(ElementName="PublicationType")]
public class PublicationType { 

	[XmlAttribute(AttributeName="UI")] 
	public string UI { get; set; } 

	[XmlText] 
	public string Text { get; set; } 
}

}