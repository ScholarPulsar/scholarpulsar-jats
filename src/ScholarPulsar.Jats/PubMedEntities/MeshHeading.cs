using System.Xml.Serialization;
using System.Collections.Generic;
namespace ScholarPulsar.Jats.PubMedEntities{ 

[XmlRoot(ElementName="MeshHeading")]
public class MeshHeading { 

	[XmlElement(ElementName="DescriptorName")] 
	public DescriptorName DescriptorName { get; set; } 

	[XmlElement(ElementName="QualifierName")] 
	public List<QualifierName> QualifierName { get; set; } 
}

}