using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using DepMon.ProviderManagement;
using System.IO;
using System.Reflection;

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
            Application.Run(new Form1());
        }
    }
}
