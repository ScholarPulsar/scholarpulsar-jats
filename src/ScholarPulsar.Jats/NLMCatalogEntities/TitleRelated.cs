using System.Xml.Serialization; 
using System.Collections.Generic; 
namespace ScholarPulsar.Jats.NLMCatalogEntities{ 

[XmlRoot(ElementName="TitleRelated")]
public class TitleRelated { 

	[XmlElement(ElementName="Title")] 
	public Title Title { get; set; } 

	[XmlElement(ElementName="RecordID")] 
	public List<RecordID> RecordID { get; set; } 

	[XmlElement(ElementName="ISSN")] 
	public ISSN ISSN { get; set; } 

	[XmlAttribute(AttributeName="Owner")] 
	public string Owner { get; set; } 

	[XmlAttribute(AttributeName="TitleType")] 
	public string TitleType { get; set; } 

	[XmlText] 
	public string Text { get; set; } 
}

}