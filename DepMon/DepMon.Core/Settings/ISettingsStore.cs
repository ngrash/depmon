using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DepMon.Provider;

namespace DepMon.Core.Settings
{
    interface ISettingsStore
    {
        void SetSettings(AppSettings settings);
        AppSettings GetSettings();
        void SetDepartureQuery(Guid guid, Type departureQueryType, IDepartureQuery query);
        IDepartureQuery GetDepartureQuery(Guid guid, Type departureQueryType);
    }
}
