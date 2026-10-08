using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace ScholarPulsar.Jats.Entities
{
    [Serializable]
    public enum JournalIdentifierType
    {

        /// <summary>
        /// Identifier assigned to a work by an archive or other repository for articles
        /// </summary>
        [XmlEnum("archive")]
        [Description("archive")]
        Archive,

        /// <summary>
        /// Identifier assigned to a work by a data aggregator
        /// </summary>
        [XmlEnum("aggregator")]
        [Description("aggregator")]
        Aggregator,


        [XmlEnum("doi")]
        [Description("doi")]
        Doi,

        /// <summary>
        /// Identifier assigned to a work by an abstracting or indexing service
        /// </summary>
        [XmlEnum("index")]
        [Description("index")]
        Index,


        [XmlEnum("issn")]
        [Description("issn")]
        ISSN,

        /// <summary>
        /// Identifier assigned to a work by PubMed, for example, “Mol Biol Cell”, “Nucleic Acids Res”, etc. This value is typically the journal abbreviation and may be the same as the abbreviated journal title <abbrev-journal-title>.
        /// </summary>
        [XmlEnum("nlm-ta")]
        [Description("nlm-ta")]
        NLMTA,

        /// <summary>
        /// Identifier assigned to a work by PubMed Central, for example, a PubMed Central journal abbreviation such as “pnas”, “mbc”, “nar”, or “molcellb”, etc. This value is typically the journal abbreviation and may be the same as the abbreviated journal title <abbrev-journal-title>.
        /// </summary>
        [XmlEnum("pmc")]
        [Description("pmc")]
        PMC,

        /// <summary>
        /// Identifier assigned to a work by the content publisher, for example, “MOLEC” or “MOLCEL”
        /// </summary>
        [XmlEnum("publisher-id")]
        [Description("publisher-id")]
        PublisherId,
    }
}
