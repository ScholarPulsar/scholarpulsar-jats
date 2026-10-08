using System.Xml.Serialization; 
using System.Collections.Generic; 
namespace ScholarPulsar.Jats.PubMedEntities{ 

[XmlRoot(ElementName="Reference")]
public class Reference { 

	[XmlElement(ElementName="Citation")] 
	public Citation Citation { get; set; } 

	[XmlElement(ElementName="ArticleIdList")] 
	public ArticleIdList ArticleIdList { get; set; } 
}

}