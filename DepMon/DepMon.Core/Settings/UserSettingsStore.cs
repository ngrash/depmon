using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Xml.Serialization;
using DepMon.Provider;

namespace DepMon.Core.Settings
{
    class UserSettingsStore : ISettingsStore
    {
        private const string _AppDataSubDir = "DepMon";
        private const string _QueriesSubDir = "Queries";

        private const string _SettingsFileName = "Settings.xml";
        private const string _QueryFileName = "{0}.xml";

        private readonly string _SettingsFilePath = string.Empty;
        private readonly string _SettingsQueryDirectory = string.Empty;

        public UserSettingsStore()
        {
            string appDataPath = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData);
            string settingsDirPath = Path.Combine(appDataPath, _AppDataSubDir);

            _SettingsFilePath = Path.Combine(settingsDirPath, _SettingsFileName);
            _SettingsQueryDirectory = Path.Combine(settingsDirPath, _QueriesSubDir);

            if (!Directory.Exists(settingsDirPath))
                Directory.CreateDirectory(settingsDirPath);

            if (!Directory.Exists(_SettingsQueryDirectory))
                Directory.CreateDirectory(_SettingsQueryDirectory);
        }

        public void SetSettings(AppSettings settings)
        {
            SerializeToFile(_SettingsFilePath, settings);
        }

        public AppSettings GetSettings()
        {
            if (!File.Exists(_SettingsFilePath))
            {
                return new AppSettings()
                {
                    Providers = new List<ProviderInfo>()
                };
            }

            return DeserializeFromFile<AppSettings>(_SettingsFilePath);
        }

        public void SetDepartureQuery(Guid guid, Type departureQueryType, IDepartureQuery query)
        {
            string queryFilePath = GetQueryFilePath(guid);
            SerializeToFile(queryFilePath, query);
        }

        public IDepartureQuery GetDepartureQuery(Guid guid, Type departureQueryType)
        {
            string queryFilePath = GetQueryFilePath(guid);
            if (!File.Exists(queryFilePath))
                return null;

            return (IDepartureQuery)DeserializeFromFile(queryFilePath, departureQueryType);
        }

        private string GetQueryFilePath(Guid guid)
        {
            string queryFile = string.Format(_QueryFileName, guid);
            return Path.Combine(_SettingsQueryDirectory, queryFile);
        }

        private void SerializeToFile(string file, object o)
        {
            using (StreamWriter writer = new StreamWriter(file))
            {
                XmlSerializer serializer = new XmlSerializer(o.GetType());
                serializer.Serialize(writer, o);
            }
        }

        private T DeserializeFromFile<T>(string file)
        {
            return (T)DeserializeFromFile(file, typeof(T));
        }

        private object DeserializeFromFile(string file, Type type)
        {
            using (StreamReader reader = new StreamReader(file))
            {
                XmlSerializer serializer = new XmlSerializer(type);
                return serializer.Deserialize(reader);
            }
        }
    }
}
