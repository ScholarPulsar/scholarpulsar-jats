using ScholarPulsar.Jats.Entities;
using System.Xml.Serialization;
namespace ScholarPulsar.Jats.PubMedEntities
{

	[XmlRoot(ElementName = "DescriptorName")]
	public class DescriptorName : InnerXmlElement
	{

		[XmlAttribute(AttributeName = "UI")]
		public string UI { get; set; }

		[XmlAttribute(AttributeName = "MajorTopicYN")]
		public string MajorTopicYN { get; set; }


	}

}