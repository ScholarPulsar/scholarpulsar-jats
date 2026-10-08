using System.Xml.Serialization;
namespace ScholarPulsar.Jats.PubMedEntities
{

	[XmlRoot(ElementName = "DateCompleted")]
	public class DateCompleted
	{

		[XmlElement(ElementName = "Year")]
		public int? Year { get; set; }

		[XmlElement(ElementName = "Month")]
		public string Month { get; set; }

		[XmlElement(ElementName = "Day")]
		public int? Day { get; set; }
	}

}