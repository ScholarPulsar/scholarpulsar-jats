using System.Collections.Generic;
using System.Xml.Serialization;
namespace ScholarPulsar.Jats.PubMedEntities
{

	[XmlRoot(ElementName = "Journal")]
	public class Journal
	{

		[XmlElement(ElementName = "ISSN")]
		public List<ISSN> ISSN { get; set; }

		[XmlElement(ElementName = "JournalIssue")]
		public JournalIssue JournalIssue { get; set; }

		[XmlElement(ElementName = "Title")]
		public string Title { get; set; }

		[XmlElement(ElementName = "ISOAbbreviation")]
		public string ISOAbbreviation { get; set; }
	}

}