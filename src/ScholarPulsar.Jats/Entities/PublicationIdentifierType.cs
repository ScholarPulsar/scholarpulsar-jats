using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace ScholarPulsar.Jats.Entities
{
    public enum PublicationIdentifierType
    {
        /// <summary>
        /// Generic identifier type for a unique identifier given to an item in a data repository. For example, a DNA or protein sequence record for tracking the sequence record and the associated sequence over time.
        /// </summary>
        [XmlEnum("accession")]
        [Description("accession")]
        Accession,

        /// <summary>
        /// Generic identifier type for an identifier assigned by an archive or other repository (generally used with elements <object-id>, <issue-id>, and <volume-id>).
        /// </summary>
        [XmlEnum("archive")]
        [Description("archive")]
        Archive,


        [XmlEnum("doi")]
        [Description("doi")]
        Doi,

        /// <summary>
        /// International Standard Book Number.
        /// </summary>
        [XmlEnum("isbn")]
        [Description("isbn")]
        Isbn,

        /// <summary>
        /// Generic identifier type for an identifier assigned to a manuscript.
        /// </summary>
        [XmlEnum("manuscript")]
        [Description("manuscript")]
        Manuscript,

        /// <summary>
        /// NLM Medline identifier.
        /// </summary>
        [XmlEnum("medline")]
        [Description("medline")]
        Medline,

        /// <summary>
        /// PubMed Central identifier.
        /// </summary>
        [XmlEnum("pmcid")]
        [Description("pmcid")]
        Pmcid,

        /// <summary>
        /// PubMed Identifier (PubMed ID). See https://www.ncbi.nlm.nih.gov/sites/entrez?db=pubmed.
        /// </summary>
        [XmlEnum("pmid")]
        [Description("pmid")]
        Pmid,
    }
}
