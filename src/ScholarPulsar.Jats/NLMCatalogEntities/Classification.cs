using System.Xml.Serialization; 
namespace ScholarPulsar.Jats.NLMCatalogEntities{ 

[XmlRoot(ElementName="Classification")]
public class Classification { 

	[XmlAttribute(AttributeName="NLMCallNumberYN")] 
	public string NLMCallNumberYN { get; set; } 

	[XmlAttribute(AttributeName="Authority")] 
	public string Authority { get; set; } 

	[XmlAttribute(AttributeName="CallNumberType")] 
	public string CallNumberType { get; set; } 

	[XmlText] 
	public string Text { get; set; } 
}

}