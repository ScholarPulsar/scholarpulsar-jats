using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ScholarPulsar.Jats.Core
{
    public static class ReferencedPublicationType
    {
        public const string JournalArticle = "journal";
        public const string Website = "web";
        public const string Book = "book";
        public const string ConferenceProceedings = "confproc";
        public const string Patent = "patent";
        public const string Thesis = "thesis";
        public const string Letter = "letter";
        public const string Review = "review";
        public const string Report = "report";
        public const string Standard = "standard";
        public const string WorkingPaper = "working-paper";
        public const string Other = "other";
    }

    public static class RefType
    {
        public const string Bibliographic = "bibr";
        public const string Figure = "fig";
        public const string Table = "table";
        public const string TableFootnote = "table-fn";
        public const string Formula = "disp-formula";
        public const string Section = "sec";
        public const string Footnote = "fn";
        public const string SupplementaryMaterial = "supplementary-material";
    }

    public static class ContributorType
    {
        public const string Author = "author";
        public const string Editor = "editor";
        public const string Illustrator = "illustrator";
        public const string Translator = "translator";
        public const string ResearchAssistant = "research-assistant";

    }
}
