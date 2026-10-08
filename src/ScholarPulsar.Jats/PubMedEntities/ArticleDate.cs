using System.Xml.Serialization;
namespace ScholarPulsar.Jats.PubMedEntities
{

	[XmlRoot(ElementName = "ArticleDate")]
	public class ArticleDate
	{

		[XmlElement(ElementName = "Year")]
		public int? Year { get; set; }

		[XmlElement(ElementName = "Month")]
		public string Month { get; set; }

		[XmlElement(ElementName = "Day")]
		public int? Day { get; set; }

		[XmlAttribute(AttributeName = "DateType")]
		public string DateType { get; set; }

		[XmlText]
		public string Text { get; set; }
	}

}