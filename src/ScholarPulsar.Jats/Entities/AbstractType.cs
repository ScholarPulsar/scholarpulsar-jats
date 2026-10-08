using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace ScholarPulsar.Jats.Entities
{
    public enum AbstractType
    {
        /// <summary>
        /// A “plain text” abstract, i.e., without special characters or equations, so the abstract can be sent in email or displayed on primitive browsers
        /// </summary>
        [XmlEnum("ASCII")]
        ASCII,

        /// <summary>
        /// A non-technical summation of the major findings of the article
        /// </summary>
        [XmlEnum("executive-summary")]
        ExecutiveSummary,

        /// <summary>
        /// A pictorial representation such as a picture or a video
        /// </summary>
        [XmlEnum("graphical")]
        Graphical,

        /// <summary>
        /// An abstract written by an editor, not an author
        /// </summary>
        [XmlEnum("editor")]
        Editor,

        /// <summary>
        /// An abstract which lists the key points made by the article
        /// </summary>
        [XmlEnum("key-points")]
        KeyPoints,

        /// <summary>
        /// An abstract used for Learning Objectives or article objectives
        /// </summary>
        [XmlEnum("objectives")]
        Objectives,

        /// <summary>
        /// An abstract containing the titles of an article’s sections; following each title, that section is summarized.
        /// </summary>
        [XmlEnum("section")]
        Section,

        /// <summary>
        /// An abbreviated form of the abstract, for example, for use inside a generated Table of Contents, or to be returned in addition to the article title during a search
        /// </summary>
        [XmlEnum("short")]
        Short,

        /// <summary>
        /// An abstract containing only the details of a chemical compound, for example, one major publisher’s “stereochem” abstract
        /// </summary>
        [XmlEnum("stereochemical")]
        Stereochemical,

        /// <summary>
        /// Summation of the article, typically used in conjunction with other types of abstracts
        /// </summary>
        [XmlEnum("summary")]
        Summary,

        /// <summary>
        /// A very short abstract, usually only a line or two long, that is displayed in a Table of Contents
        /// </summary>
        [XmlEnum("toc")]
        Toc,

        /// <summary>
        /// Short summary intended for distribution on a website
        /// </summary>
        [XmlEnum("web-summary")]
        WebSummary,
    }
}
