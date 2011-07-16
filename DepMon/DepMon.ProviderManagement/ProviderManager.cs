using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Reflection;
using DepMon.Core;

namespace DepMon.ProviderManagement
{
    public static class ProviderManager
    {
        private static List<IProvider> _knownProviders = new List<IProvider>();

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

                    // public default constructor
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
            if (_knownProviders.Contains(provider))
                throw new ArgumentException();

            _knownProviders.Add(provider);
        }

        public static ICollection<IProvider> ListAllKnownProviders()
        {
            return _knownProviders;
        }
    }
}
