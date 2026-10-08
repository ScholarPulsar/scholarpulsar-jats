using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace ScholarPulsar.Jats.Entities
{
    public enum CollaborationType
    {
        /// <summary>
        /// Group or company to whom a patent is awarded
        /// </summary>
        [XmlEnum("assignee")]
        Assignee,

        /// <summary>
        /// Content creators
        /// </summary>
        [XmlEnum("authors")]
        Authors,

        /// <summary>
        /// Content editors
        /// </summary>
        [XmlEnum("editors")]
        Editors,

        /// <summary>
        /// Person or group that has put together a composite work from multiple sources
        /// </summary>
        [XmlEnum("compilers")]
        Compilers,

        /// <summary>
        /// A group of editors that has been invited to edit all or part of a work
        /// </summary>
        [XmlEnum("guest-editors")]
        GuestEditors,
    }
}
