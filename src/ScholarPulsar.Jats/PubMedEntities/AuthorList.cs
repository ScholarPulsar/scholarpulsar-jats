using System.Xml.Serialization; 
using System.Collections.Generic; 
namespace ScholarPulsar.Jats.PubMedEntities{ 

[XmlRoot(ElementName="AuthorList")]
public class AuthorList { 

	[XmlElement(ElementName="Author")] 
	public List<Author> Author { get; set; } 

	[XmlAttribute(AttributeName="CompleteYN")] 
	public string CompleteYN { get; set; } 

	[XmlText] 
	public string Text { get; set; } 
}

}