using System.Xml.Serialization; 
namespace ScholarPulsar.Jats.NLMCatalogEntities{ 

[XmlRoot(ElementName="Language")]
public class Language { 

	[XmlAttribute(AttributeName="LangType")] 
	public string LangType { get; set; } 

	[XmlText] 
	public string Text { get; set; } 
}

}