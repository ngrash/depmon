using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DepMon.Settings
{
    public interface IAppSettings
    {
        ProviderItem Provider { get; }
        IEnumerable<StationItem> Stations { get; }

        void Load();
        void Save();
        bool Exist();
    }
}
