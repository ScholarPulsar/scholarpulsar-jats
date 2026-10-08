using System.Xml.Serialization; 
namespace ScholarPulsar.Jats.NLMCatalogEntities{ 

[XmlRoot(ElementName="LocalNote")]
public class LocalNote { 

	[XmlAttribute(AttributeName="LocalNoteType")] 
	public string LocalNoteType { get; set; } 

	[XmlText] 
	public string Text { get; set; } 
}

}