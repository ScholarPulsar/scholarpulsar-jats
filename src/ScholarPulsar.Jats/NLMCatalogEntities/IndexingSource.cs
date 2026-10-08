using System.Xml.Serialization; 
namespace ScholarPulsar.Jats.NLMCatalogEntities{ 

[XmlRoot(ElementName="IndexingSource")]
public class IndexingSource { 

	[XmlElement(ElementName="IndexingSourceName")] 
	public IndexingSourceName IndexingSourceName { get; set; } 

	[XmlElement(ElementName="Coverage")] 
	public string Coverage { get; set; } 
}

}