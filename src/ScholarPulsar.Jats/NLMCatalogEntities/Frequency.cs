using System.Xml.Serialization; 
namespace ScholarPulsar.Jats.NLMCatalogEntities{ 

[XmlRoot(ElementName="Frequency")]
public class Frequency { 

	[XmlAttribute(AttributeName="FrequencyType")] 
	public string FrequencyType { get; set; } 

	[XmlText] 
	public string Text { get; set; } 
}

}