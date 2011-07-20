using System.IO;
using System.Reflection;
using System.Windows.Forms;
using System.Linq;
using DepMon.Core;
using DepMon.Core.Settings;
using DepMon.Provider;
using System.Collections.Generic;

namespace DepMon
{
    class App
    {
        public const string _ProvidersDir = "Providers";

        public App()
        {
            string appDir = Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location);
            string absolutProvidersDir = Path.Combine(appDir, _ProvidersDir);

            // load all providers from provider sub directory
            foreach (string file in Directory.EnumerateFiles(absolutProvidersDir, "*.dll"))
            {
                string filePath = Path.Combine(_ProvidersDir, file);
                ProviderManager.AddProviderAssembly(filePath);
            }
        }

        public void Run()
        {
            DepartureQueryRepository queryRepository = new DepartureQueryRepository();
            Dictionary<IProvider, List<IDepartureQuery>> providerQueries = new Dictionary<IProvider, List<IDepartureQuery>>();
            bool hasQueries = false;
            foreach(IProvider provider in ProviderManager.ListAllKnownProviders()) {
                providerQueries.Add(provider, new List<IDepartureQuery>());

                foreach (IDepartureQuery query in queryRepository.ListAll(provider))
                {
                    hasQueries = true;
                    providerQueries[provider].Add(query);
                }
            }

            if (!hasQueries)
            {
                AddNewForm addForm = new AddNewForm();
                addForm.ShowDialog();

                if (addForm.DepartureQuery != null)
                {
                    queryRepository.Add(addForm.DepartureQuery, addForm.SelectedProvider);
                }
            }

            AppIcon icon = new AppIcon();
            icon.Exit += (s, e) => Application.Exit();
            icon.Show();

            Application.Run();
        }
    }
}
