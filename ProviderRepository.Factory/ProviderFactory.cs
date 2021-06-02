using System;
using System.Configuration;
using System.Reflection;
using System.Runtime.Loader;
using ProviderRepository.Interface;

namespace ProviderRepository.Factory
{
    public static class RepositoryFactory
    {
        public static IProviderRepository GetProvider()
        {
            string providerTypeName = ConfigurationManager.AppSettings["ProviderType"];
            Type providerType = Type.GetType(providerTypeName);
            IProviderRepository providerRepository = Activator.CreateInstance(providerType) as IProviderRepository;
            return providerRepository;


        }
        

    }
}