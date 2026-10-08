using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace ScholarPulsar.Jats.Entities
{
    public enum DateType
    {
        [XmlEnum("accepted")]
        [Description("accepted")]
        Accepted,

        [XmlEnum("corrected")]
        [Description("corrected")]
        Corrected,

        [XmlEnum("pub")]
        [Description("pub")]
        Publication,

        [XmlEnum("preprint")]
        [Description("preprint")]
        Preprint,

        [XmlEnum("received")]
        [Description("received")]
        Received,

        [XmlEnum("resubmitted")]
        [Description("resubmitted")]
        Resubmitted,

        [XmlEnum("retracted")]
        [Description("retracted")]
        Retracted,

        [XmlEnum("rev-recd")]
        [Description("rev-recd")]
        RevisionReceived,

        [XmlEnum("rev-request")]
        [Description("rev-request")]
        RevisionRequest,

    }
}
