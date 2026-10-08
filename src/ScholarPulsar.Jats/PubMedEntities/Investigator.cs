using System.Xml.Serialization; 
using System.Collections.Generic;
namespace ScholarPulsar.Jats.PubMedEntities
{

	[XmlRoot(ElementName = "Investigator")]
	public class Investigator
    {


		[XmlAttribute(AttributeName = "ValidYN")]
		public string ValidYN { get; set; }


		[XmlElement(ElementName = "LastName")]
		public string LastName { get; set; }

		[XmlElement(ElementName = "ForeName")]
		public string ForeName { get; set; }

		[XmlElement(ElementName = "Initials")]
		public string Initials { get; set; }

		


    }

}