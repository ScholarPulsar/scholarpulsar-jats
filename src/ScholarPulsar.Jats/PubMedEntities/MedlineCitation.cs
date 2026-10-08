using System.Xml.Serialization; 
using System.Collections.Generic;
namespace ScholarPulsar.Jats.PubMedEntities
{

	[XmlRoot(ElementName = "MedlineCitation")]
	public class MedlineCitation
	{

		[XmlElement(ElementName = "PMID")]
		public PMID PMID { get; set; }

		[XmlElement(ElementName = "DateCompleted")]
		public DateCompleted DateCompleted { get; set; }

		[XmlElement(ElementName = "DateRevised")]
		public DateRevised DateRevised { get; set; }

		[XmlElement(ElementName = "Article")]
		public Article Article { get; set; }

		[XmlElement(ElementName = "MedlineJournalInfo")]
		public MedlineJournalInfo MedlineJournalInfo { get; set; }

		[XmlElement(ElementName = "CitationSubset")]
		public string CitationSubset { get; set; }

		[XmlElement(ElementName = "MeshHeadingList")]
		public MeshHeadingList MeshHeadingList { get; set; }

		[XmlElement(ElementName = "KeywordList")]
		public KeywordList KeywordList { get; set; }

        [XmlElement(ElementName = "InvestigatorList")]
        public InvestigatorList InvestigatorList { get; set; }

        [XmlAttribute(AttributeName = "Status")]
		public string Status { get; set; }

		[XmlAttribute(AttributeName = "Owner")]
		public string Owner { get; set; }

		[XmlText]
		public string Text { get; set; }
	}

}