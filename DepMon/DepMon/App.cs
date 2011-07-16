using System.IO;
using System.Reflection;
using System.Windows.Forms;
using DepMon.Settings;
using DepMon.Core;

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
            IAppSettings settings = new UserSettings();

            if (!settings.Exist())
            {
                Application.Run(new FormSetup());
            }
        }
    }
}
