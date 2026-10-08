using System.Xml.Serialization; 
using System.Collections.Generic; 
namespace ScholarPulsar.Jats.PubMedEntities{ 

[XmlRoot(ElementName="PublicationTypeList")]
public class PublicationTypeList { 

	[XmlElement(ElementName="PublicationType")] 
	public List<PublicationType> PublicationType { get; set; } 
}

}