using System;
using System.Threading.Tasks;
using Provider.vultr.Processor;
using ProviderRepository.Factory;
using ProviderRepository.Interface;
using vultr.Model;


namespace cmdVpsManager
{
    class Program
    {
        static async Task Main(string[] args)
        {
            IProviderRepository repository = RepositoryFactory.GetProvider();
            VultrProcessor processor = (VultrProcessor) repository;
            AccountWrapper wrapper = processor.GetAccount().GetAwaiter().GetResult();
            Console.WriteLine("done");
            
        }
    }
}