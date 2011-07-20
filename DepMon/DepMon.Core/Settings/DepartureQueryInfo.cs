using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml.Serialization;

namespace DepMon.Core.Settings
{
    public class DepartureQueryInfo
    {
        public DepartureQueryInfo() { }

        public DepartureQueryInfo(Guid guid)
        {
            DepartureQueryID = guid;
        }

        [XmlAttribute("guid")]
        public Guid DepartureQueryID
        {
            get;
            set;
        }
    }
}
