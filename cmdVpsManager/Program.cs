using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using CommandLine;
using Provider.vultr.Processor;
using ProviderRepository.Factory;
using ProviderRepository.Interface;
using vultr.Model;


namespace cmdVpsManager
{
    class Program
    {
        static void Main(string[] args)
        {
            Parser.Default.ParseArguments<CommandLineOptions>(args)
                .WithParsed(options => RunOptions(options))
                .WithNotParsed((error) => HandleParseError(error));
        }

        private static void HandleParseError(IEnumerable<Error> error)
        {
            Console.WriteLine("Command Line parameters were not correct");
        }

        private static void RunOptions(CommandLineOptions options)
        {
            IProviderRepository repository = RepositoryFactory.GetProvider();
            VultrProcessor processor = (VultrProcessor) repository;
            AccountWrapper wrapper = processor.GetAccount().GetAwaiter().GetResult();
            Console.WriteLine(wrapper.Account.Email);
            OperatingSystems operatingSystems = processor.ListOperatingSystems().GetAwaiter().GetResult();
            Console.WriteLine(operatingSystems.Os.Count);
            foreach (var os in operatingSystems.Os)
            {
                Console.WriteLine(os.name);
            }
        }
    }
}