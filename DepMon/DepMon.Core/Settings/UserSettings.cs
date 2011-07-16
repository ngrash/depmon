using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Xml.Serialization;

namespace DepMon.Settings
{
    public class UserSettings : IAppSettings
    {
        private const string _AppDataSubDir = "DepMon";
        private const string _SettingsFileName = "config.xml";

        public ProviderItem Provider
        {
            get;
            set;
        }

        public IEnumerable<StationItem> Stations
        {
            get;
            set;
        }

        public void Load()
        {
            string configFile = GetConfigFile();

            using (StreamReader settingsReader = new StreamReader(configFile))
            {
                XmlSerializer settingsSerializer = new XmlSerializer(typeof(UserSettings));
                UserSettings settings = (UserSettings)settingsSerializer.Deserialize(settingsReader);

                Stations = settings.Stations;
                Provider = settings.Provider;
            }
        }

        public void Save()
        {
            string configFile = GetConfigFile();

            using (StreamWriter settingsWriter = new StreamWriter(configFile))
            {
                XmlSerializer settingsSerializer = new XmlSerializer(typeof(UserSettings));
                settingsSerializer.Serialize(settingsWriter, this);
            }
        }

        public bool Exist()
        {
            string configFile = GetConfigFile();
            return File.Exists(configFile);
        }

        private string GetConfigFile()
        {
            string appDataDir = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData);
            string subDir = Path.Combine(appDataDir, _AppDataSubDir);
            string configFile = Path.Combine(subDir, _SettingsFileName);

            return configFile;
        }
    }
}
