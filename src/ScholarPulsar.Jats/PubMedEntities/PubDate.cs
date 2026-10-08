using System.Xml.Serialization;
namespace ScholarPulsar.Jats.PubMedEntities
{

	[XmlRoot(ElementName = "PubDate")]
	public class PubDate
	{

		[XmlElement(ElementName = "Year")]
		public int? Year { get; set; }

		[XmlElement(ElementName = "Month")]
		public string Month { get; set; }

		[XmlElement(ElementName = "Day")]
		public string Day { get; set; }

		[XmlElement(ElementName = "Season")]
		public string Season { get; set; }

		[XmlElement(ElementName = "MedlineDate")]
		public string MedlineDate { get; set; }
	}

}