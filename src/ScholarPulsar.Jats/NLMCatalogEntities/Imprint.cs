using System.Xml.Serialization; 
namespace ScholarPulsar.Jats.NLMCatalogEntities{ 

[XmlRoot(ElementName="Imprint")]
public class Imprint { 

	[XmlElement(ElementName="Place")] 
	public string Place { get; set; } 

	[XmlElement(ElementName="Entity")] 
	public string Entity { get; set; } 

	[XmlElement(ElementName="DateIssued")] 
	public string DateIssued { get; set; } 

	[XmlElement(ElementName="ImprintFull")] 
	public string ImprintFull { get; set; } 

	[XmlAttribute(AttributeName="ImprintType")] 
	public string ImprintType { get; set; } 

	[XmlAttribute(AttributeName="FunctionType")] 
	public string FunctionType { get; set; } 

	[XmlText] 
	public string Text { get; set; } 
}

}