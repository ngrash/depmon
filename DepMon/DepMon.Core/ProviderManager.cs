using System;
using System.Collections.Generic;
using System.Reflection;
using DepMon.Provider;

namespace DepMon.Core
{
    public static class ProviderManager
    {
        private static Dictionary<Guid, IProvider> _knownProviders = new Dictionary<Guid, IProvider>();

        public static void AddProviderAssembly(string file)
        {
            Assembly assembly = Assembly.LoadFile(file);
            AddProviderAssembly(assembly);
        }

        public static void AddProviderAssembly(Assembly assembly)
        {
            bool containsProvider = false;

            foreach (Type type in assembly.GetTypes())
            {
                if (typeof(IProvider).IsAssignableFrom(type))
                {
                    containsProvider = true;

                    // find and invoke public default constructor
                    ConstructorInfo constructor = type.GetConstructor(Type.EmptyTypes);
                    IProvider provider = (IProvider)constructor.Invoke(null);
                    AddProvider(provider);
                }
            }

            if (!containsProvider)
                throw new ArgumentException();
        }

        public static void AddProvider(IProvider provider)
        {
            if(_knownProviders.ContainsKey(provider.UniqueID))
                throw new ArgumentException();

            _knownProviders.Add(provider.UniqueID, provider);
        }

        public static IProvider GetProviderByID(Guid uniqueID)
        {
            return _knownProviders[uniqueID];
        }

        public static ICollection<IProvider> ListAllKnownProviders()
        {
            return _knownProviders.Values;
        }
    }
}
