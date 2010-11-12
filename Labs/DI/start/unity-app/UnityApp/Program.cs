using System;
using System.Configuration;
using Microsoft.Practices.Unity;
using Microsoft.Practices.Unity.Configuration;
using Primes;

namespace UnityApp
{
    class Program
    {
        static void Main(string[] args)
        {
            using (var container = new UnityContainer())
            {
                //configure container
                // TODO 2.0 Call ConfigureContainerUsingXML
                ConfigureContainerUsingAPI(container);

                //ask container for objects and use them
                var report = container.Resolve<ConsoleReport>();
                report.Write();

                Console.WriteLine("--- hit enter to exit --");
                Console.ReadLine();
            }
        }

        private static void ConfigureContainerUsingAPI(UnityContainer container)
        {
            // TODO 1.0 Use configuration api to configure the primes application

            // TODO 5.0 Switch to using LinqPrimeGenerator
        }

        private static void ConfigureContainerUsingXML(UnityContainer container)
        {
            var section = (UnityConfigurationSection)ConfigurationManager.GetSection("unity");
            section.Containers.Default.Configure(container);      
        }
    }
}
