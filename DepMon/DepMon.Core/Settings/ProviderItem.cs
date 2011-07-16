using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml.Serialization;

namespace DepMon.Settings
{
    public class ProviderItem
    {
        [XmlAttribute("name")]
        public string Name { get; set; }
    }
}
