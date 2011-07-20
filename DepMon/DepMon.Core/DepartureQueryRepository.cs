using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DepMon.Provider;
using DepMon.Core.Settings;

namespace DepMon.Core
{
    public class DepartureQueryRepository
    {
        ISettingsStore _settingsStore = new UserSettingsStore();
        AppSettings _settings = null;

        public DepartureQueryRepository()
        {
            _settings = _settingsStore.GetSettings();
        }

        public void Add(IDepartureQuery query, IProvider provider)
        {
            ProviderInfo providerInfo = _settings.Providers.SingleOrDefault(p => p.ProviderID == provider.UniqueID);
            if (providerInfo == null)
            {
                providerInfo = new ProviderInfo()
                {
                    ProviderID = provider.UniqueID,
                    Queries = new List<DepartureQueryInfo>()
                };
                _settings.Providers.Add(providerInfo);
            }

            DepartureQueryInfo queryInfo = new DepartureQueryInfo(Guid.NewGuid());
            providerInfo.Queries.Add(queryInfo);

            _settingsStore.SetDepartureQuery(queryInfo.DepartureQueryID, query.GetType(), query);
            _settingsStore.SetSettings(_settings);
        }

        public IEnumerable<IDepartureQuery> ListAll(IProvider provider)
        {
            ProviderInfo providerInfo = _settings.Providers.SingleOrDefault(p => p.ProviderID == provider.UniqueID);

            if (providerInfo == null)
                yield break;

            foreach (DepartureQueryInfo queryInfo in providerInfo.Queries)
            {
                yield return _settingsStore.GetDepartureQuery(queryInfo.DepartureQueryID, provider.DepartureQueryType);
            }
        }
    }
}
