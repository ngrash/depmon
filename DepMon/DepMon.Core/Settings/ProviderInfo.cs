using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DepMon.Provider;
using System.Xml.Serialization;

namespace DepMon.Core.Settings
{
    public class ProviderInfo
    {
        [XmlAttribute("provider")]
        public Guid ProviderID
        {
            get;
            set;
        }

        public List<DepartureQueryInfo> Queries
        {
            get;
            set;
        }
    }
}
