using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace ScholarPulsar.Jats.Entities
{
    public enum NameStyle
    {
        [XmlEnum("eastern")]
        Eastern,

        [XmlEnum("given-only")]
        GivenOnly,

        /// <summary>
        /// The name will both be displayed and sorted/inverted with the given name preceding the family name.
        /// </summary>
        [XmlEnum("islensk")]
        Islensk,

        [XmlEnum("western")]
        Western,

    }
}
