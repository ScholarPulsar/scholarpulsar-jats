using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace ScholarPulsar.Jats.Entities
{
    public enum CrossReferenceType
    {
        [XmlEnum("aff")]
        Affiliation,

        [XmlEnum("app")]
        Appendix,

        [XmlEnum("author-notes")]
        AuthorNotes,

        [XmlEnum("award")]
        Award,

        [XmlEnum("bibr")]
        Bibliographic,

        [XmlEnum("bio")]
        Biography,

        [XmlEnum("boxed-text")]
        BoxedText,

        [XmlEnum("chem")]
        ChemicalStructure,

        [XmlEnum("collab")]
        Collaboration,

        [XmlEnum("contrib")]
        Contributor,

        [XmlEnum("corresp")]
        CorrespondingAuthor,

        [XmlEnum("disp-formula")]
        DisplayFormula,

        [XmlEnum("fig")]
        Figure,

        [XmlEnum("fn")]
        Footnote,

        [XmlEnum("kwd")]
        Keyword,

        [XmlEnum("list")]
        List,

        [XmlEnum("other")]
        Other,

        [XmlEnum("plate")]
        Plate,

        [XmlEnum("scheme")]
        Scheme,

        [XmlEnum("sec")]
        Section,

        [XmlEnum("statement")]
        Statement,

        [XmlEnum("supplementary-material")]
        SupplementaryInformation,

        [XmlEnum("table")]
        Table,
    }
}
