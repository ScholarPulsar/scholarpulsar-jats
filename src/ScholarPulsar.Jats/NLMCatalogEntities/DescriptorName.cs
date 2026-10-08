using System.Xml.Serialization; 
namespace ScholarPulsar.Jats.NLMCatalogEntities{ 

[XmlRoot(ElementName="DescriptorName")]
public class DescriptorName { 

	[XmlAttribute(AttributeName="MajorTopicYN")] 
	public string MajorTopicYN { get; set; } 

	[XmlText] 
	public string Text { get; set; } 
}

}