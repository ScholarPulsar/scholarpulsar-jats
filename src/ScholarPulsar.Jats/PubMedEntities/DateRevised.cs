using System.Xml.Serialization;
namespace ScholarPulsar.Jats.PubMedEntities
{

	[XmlRoot(ElementName = "DateRevised")]
	public class DateRevised
	{

		[XmlElement(ElementName = "Year")]
		public int? Year { get; set; }

		[XmlElement(ElementName = "Month")]
		public string Month { get; set; }

		[XmlElement(ElementName = "Day")]
		public int? Day { get; set; }
	}

}