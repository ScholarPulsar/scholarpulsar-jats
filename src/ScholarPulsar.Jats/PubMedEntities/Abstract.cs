using System.Xml.Serialization; 
using System.Collections.Generic;
namespace ScholarPulsar.Jats.PubMedEntities
{

	[XmlRoot(ElementName = "Abstract")]
	public class Abstract
	{

		[XmlElement(ElementName = "AbstractText")]
		public List<AbstractText> AbstractText { get; set; }

		[XmlElement(ElementName = "CopyrightInformation")]
		public CopyrightInformation CopyrightInformation { get; set; }
	}

}