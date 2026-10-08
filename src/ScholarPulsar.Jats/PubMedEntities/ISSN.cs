using System.Xml.Serialization; 
namespace ScholarPulsar.Jats.PubMedEntities{ 

[XmlRoot(ElementName="ISSN")]
public class ISSN { 

	[XmlAttribute(AttributeName="IssnType")] 
	public string IssnType { get; set; } 

	[XmlText] 
	public string Text { get; set; } 
}

}