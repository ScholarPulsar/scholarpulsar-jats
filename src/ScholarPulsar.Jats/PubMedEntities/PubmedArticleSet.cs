using System.Collections.Generic;
using System.Xml.Serialization;
namespace ScholarPulsar.Jats.PubMedEntities
{

	[XmlRoot(ElementName = "PubmedArticleSet")]
	public class PubmedArticleSet
	{

		[XmlElement(ElementName = "PubmedArticle")]
		public List<PubmedArticle> PubmedArticles { get; set; }

		[XmlElement(ElementName = "PubmedBookArticle")]
		public List<PubmedBookArticle> PubmedBookArticles { get; set; }
	}

}