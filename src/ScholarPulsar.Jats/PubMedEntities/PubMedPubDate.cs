using System.Xml.Serialization; 
namespace ScholarPulsar.Jats.PubMedEntities{ 

[XmlRoot(ElementName="PubMedPubDate")]
public class PubMedPubDate { 

	[XmlElement(ElementName="Year")] 
	public int? Year { get; set; } 

	[XmlElement(ElementName="Month")] 
	public string Month { get; set; } 

	[XmlElement(ElementName="Day")] 
	public int? Day { get; set; } 

	[XmlAttribute(AttributeName="PubStatus")] 
	public string PubStatus { get; set; } 

	[XmlText] 
	public string Text { get; set; } 

	[XmlElement(ElementName="Hour")] 
	public int? Hour { get; set; } 

	[XmlElement(ElementName="Minute")] 
	public int? Minute { get; set; } 
}

}