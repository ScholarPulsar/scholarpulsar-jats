using System.Xml.Serialization; 
namespace ScholarPulsar.Jats.NLMCatalogEntities{ 

[XmlRoot(ElementName="MeshHeading")]
public class MeshHeading { 

	[XmlElement(ElementName="DescriptorName")] 
	public DescriptorName DescriptorName { get; set; } 

	[XmlAttribute(AttributeName="URI")] 
	public string URI { get; set; } 

	[XmlText] 
	public string Text { get; set; } 
}

}