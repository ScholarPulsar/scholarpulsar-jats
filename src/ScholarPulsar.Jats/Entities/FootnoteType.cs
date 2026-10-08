using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace ScholarPulsar.Jats.Entities
{
    public enum FootnoteType
    {
        [XmlEnum("abbr")]
        Abbreviations,

        [XmlEnum("com")]
        CommunicatedByInformation,

        [XmlEnum("con")]
        ContributedyByInformation,

        [XmlEnum("coi-statement")]
        ConflictOfInterestStatements,
        /// <summary>
        /// Older term for Conflict of Interest statements. “coi-statement” is now a JATS4R recommendation.
        /// </summary>
        [XmlEnum("conflict")]
        Conflict,

        /// <summary>
        /// Corresponding author information not identified separately, but merely footnoted.
        /// </summary>
        [XmlEnum("corresp")]
        CorrespondingAuthorInformation,

        /// <summary>
        /// Contributor’s current affiliation.
        /// </summary>
        [XmlEnum("current-aff")]
        CurrentAffiliation,

        /// <summary>
        /// Person has died since article was written.
        /// </summary>
        [XmlEnum("deceased")]
        Deceased,

        /// <summary>
        /// Contributor has the role of an editor.
        /// </summary>
        [XmlEnum("edited-by")]
        Editor,

        /// <summary>
        /// Contributed equally to the creation of the document.
        /// </summary>
        [XmlEnum("equal")]
        Equal,

        /// <summary>
        /// Statement of funding or denial of funds received in support of the research on which an article is based.
        /// </summary>
        [XmlEnum("financial-disclosure")]
        FinancialDisclosure,

        /// <summary>
        /// Contributor is on sabbatical or other leave of absence.
        /// </summary>
        [XmlEnum("on-leave")]
        OnLeave,

        /// <summary>
        /// Some footnote type, other than those enumerated.
        /// </summary>
        [XmlEnum("other")]
        Other,

        /// <summary>
        /// Contributor was a researcher for an article.
        /// </summary>
        [XmlEnum("participating-researchers")]
        ParticipatingResearchers,

        /// <summary>
        /// Contributor’s current address.
        /// </summary>
        [XmlEnum("present-address")]
        PresentAddress,

        /// <summary>
        /// Conference, colloquium, or other occasion at which this paper was presented.
        /// </summary>
        [XmlEnum("presented-at")]
        PresentedAt,

        /// <summary>
        /// Contributor who presented the material.
        /// </summary>
        [XmlEnum("presented-by")]
        PresentedBy,

        /// <summary>
        /// Contributor’s previous location or affiliation.
        /// </summary>
        [XmlEnum("previously-at")]
        PreviouslyAt,

        /// <summary>
        /// Contributor was a member of the study group for the research.
        /// </summary>
        [XmlEnum("study-group-members")]
        StudyGroupMembers,

        /// <summary>
        /// Points to or describes supplementary material for the article.
        /// </summary>
        [XmlEnum("supplementary-material")]
        SupplementaryMaterial,

        /// <summary>
        /// Research upon which an article is based was supported by some entity.
        /// </summary>
        [XmlEnum("supported-by")]    
        SupportedBy,
    }
}
