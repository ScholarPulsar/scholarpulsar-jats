using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace ScholarPulsar.Jats.Entities
{
    public enum PubType
    {
        /// <summary>
        /// Electronic publication (usually web, but also includes eBook, CD-ROM, or other electronic-only distribution)
        /// </summary>
        [XmlEnum("epub")]
        [Description("epub")]
        Epub,

        /// <summary>
        /// Print publication
        /// </summary>
        [XmlEnum("ppub")]
        [Description("ppub")]
        Ppub,


        [XmlEnum("epub-ppub")]
        [Description("epub-ppub")]
        EpubPpub,

        /// <summary>
        /// Electronic preprint dissemination
        /// </summary>
        [XmlEnum("epreprint")]
        [Description("epreprint")]
        Epreprint,

        /// <summary>
        /// Print preprint dissemination
        /// </summary>
        [XmlEnum("ppreprint")]
        [Description("ppreprint")]
        Ppreprint,

        /// <summary>
        /// Corrected in electronic
        /// </summary>
        [XmlEnum("ecorrected")]
        [Description("ecorrected")]
        Ecorrected,

        /// <summary>
        /// Corrected in print
        /// </summary>
        [XmlEnum("pcorrected")]
        [Description("pcorrected")]
        Pcorrected,

        /// <summary>
        /// Retracted in electronic
        /// </summary>
        [XmlEnum("eretracted")]
        [Description("eretracted")]
        Eretracted,

        /// <summary>
        /// Retracted in print
        /// </summary>
        [XmlEnum("pretracted")]
        [Description("pretracted")]
        Pretracted,
    }
}
