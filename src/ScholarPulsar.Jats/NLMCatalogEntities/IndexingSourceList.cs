using System.Xml.Serialization; 
using System.Collections.Generic; 
namespace ScholarPulsar.Jats.NLMCatalogEntities{ 

[XmlRoot(ElementName="IndexingSourceList")]
public class IndexingSourceList { 

	[XmlElement(ElementName="IndexingSource")] 
	public List<IndexingSource> IndexingSource { get; set; } 
}

}