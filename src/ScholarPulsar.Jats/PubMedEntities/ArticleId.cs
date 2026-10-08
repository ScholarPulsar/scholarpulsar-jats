using System.Xml.Serialization; 
namespace ScholarPulsar.Jats.PubMedEntities{ 

[XmlRoot(ElementName="ArticleId")]
public class ArticleId { 

	[XmlAttribute(AttributeName="IdType")] 
	public string IdType { get; set; } 

	[XmlText] 
	public string Text { get; set; } 
}

}