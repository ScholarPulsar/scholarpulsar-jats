using System.Xml.Serialization; 
using System.Collections.Generic; 
namespace ScholarPulsar.Jats.NLMCatalogEntities{ 

[XmlRoot(ElementName="NLMCatalogRecord")]
public class NLMCatalogRecord { 

	[XmlElement(ElementName="NlmUniqueID")] 
	public string NlmUniqueID { get; set; } 

	[XmlElement(ElementName="DateCreated")] 
	public DateCreated DateCreated { get; set; } 

	[XmlElement(ElementName="DateRevised")] 
	public DateRevised DateRevised { get; set; } 

	[XmlElement(ElementName="DateAuthorized")] 
	public DateAuthorized DateAuthorized { get; set; } 

	[XmlElement(ElementName="DateCompleted")] 
	public DateCompleted DateCompleted { get; set; } 

	[XmlElement(ElementName="DateRevisedMajor")] 
	public DateRevisedMajor DateRevisedMajor { get; set; } 

	[XmlElement(ElementName="TitleMain")] 
	public TitleMain TitleMain { get; set; } 

	[XmlElement(ElementName="MedlineTA")] 
	public string MedlineTA { get; set; } 

	[XmlElement(ElementName="TitleAlternate")] 
	public List<TitleAlternate> TitleAlternate { get; set; } 

	[XmlElement(ElementName="TitleRelated")] 
	public List<TitleRelated> TitleRelateds { get; set; } 

	[XmlElement(ElementName="AuthorList")] 
	public AuthorList AuthorList { get; set; } 

	[XmlElement(ElementName="ResourceInfo")] 
	public ResourceInfo ResourceInfo { get; set; } 

	[XmlElement(ElementName="PublicationTypeList")] 
	public PublicationTypeList PublicationTypeList { get; set; } 

	[XmlElement(ElementName="PublicationInfo")] 
	public PublicationInfo PublicationInfo { get; set; } 

	[XmlElement(ElementName="Language")] 
	public Language Language { get; set; } 

	[XmlElement(ElementName="PhysicalDescription")] 
	public PhysicalDescription PhysicalDescription { get; set; } 

	[XmlElement(ElementName="IndexingSourceList")] 
	public IndexingSourceList IndexingSourceList { get; set; } 

	[XmlElement(ElementName="GeneralNote")] 
	public List<GeneralNote> GeneralNote { get; set; } 

	[XmlElement(ElementName="LocalNote")] 
	public LocalNote LocalNote { get; set; } 

	[XmlElement(ElementName="MeshHeadingList")] 
	public MeshHeadingList MeshHeadingList { get; set; } 

	[XmlElement(ElementName="Classification")] 
	public Classification Classification { get; set; } 

	[XmlElement(ElementName="ELocationList")] 
	public ELocationList ELocationList { get; set; } 

	[XmlElement(ElementName="LCCN")] 
	public LCCN LCCN { get; set; } 

	[XmlElement(ElementName="ISSN")] 
	public List<ISSN> ISSN { get; set; } 

	[XmlElement(ElementName="ISSNLinking")] 
	public ISSNLinking ISSNLinking { get; set; } 

	[XmlElement(ElementName="Coden")] 
	public string Coden { get; set; } 

	[XmlAttribute(AttributeName="Owner")] 
	public string Owner { get; set; } 

	[XmlAttribute(AttributeName="Status")] 
	public string Status { get; set; } 

	[XmlText] 
	public string Text { get; set; } 
}

}