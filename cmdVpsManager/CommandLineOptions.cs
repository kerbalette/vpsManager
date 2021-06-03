using CommandLine;

namespace cmdVpsManager
{
    public class CommandLineOptions
    {
        [Option('p',"provider", Required = false, Default = "vultr", HelpText="VPS Provider: vultr, digitalocean")]
        public string Provider { get; set;}
    }
}