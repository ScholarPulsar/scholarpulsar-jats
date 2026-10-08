using System.Xml.Serialization; 
namespace ScholarPulsar.Jats.PubMedEntities{ 

[XmlRoot(ElementName="JournalIssue")]
public class JournalIssue { 

	[XmlElement(ElementName="Volume")] 
	public string Volume { get; set; } 

	[XmlElement(ElementName="Issue")] 
	public string Issue { get; set; } 

	[XmlElement(ElementName="PubDate")] 
	public PubDate PubDate { get; set; } 

	[XmlAttribute(AttributeName="CitedMedium")] 
	public string CitedMedium { get; set; } 

	[XmlText] 
	public string Text { get; set; } 
}

}