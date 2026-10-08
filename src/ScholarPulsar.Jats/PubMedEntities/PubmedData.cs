using System.Xml.Serialization; 
using System.Collections.Generic; 
namespace ScholarPulsar.Jats.PubMedEntities{ 

[XmlRoot(ElementName="PubmedData")]
public class PubmedData { 

	[XmlElement(ElementName="History")] 
	public History History { get; set; } 

	[XmlElement(ElementName="PublicationStatus")] 
	public string PublicationStatus { get; set; } 

	[XmlElement(ElementName="ArticleIdList")] 
	public ArticleIdList ArticleIdList { get; set; } 

	[XmlElement(ElementName="ReferenceList")] 
	public ReferenceList ReferenceList { get; set; } 
}

}