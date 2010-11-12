using System;
using System.Configuration;
using Microsoft.Practices.Unity;
using Microsoft.Practices.Unity.Configuration;
using Primes;

namespace UnityApp
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            using (var container = new UnityContainer())
            {
                //configure container
                // TODO 2 - call ConfigureContainerUsingXML
                ConfigureContainerUsingXML(container);

                //ask container for objects and use them
                var report = container.Resolve<ConsoleReport>();
                report.Write();
                
                Console.WriteLine("--- hit enter to exit --");
                Console.ReadLine();
            }
        }

        private static void ConfigureContainerUsingAPI(UnityContainer container)
        {
            // TODO 1 - use configuration api to configure the primes application
            // TODO 6 Use LinqPrimeGenerator instead of PrimeGenerator
            container
                .RegisterType<IOutputFormatter, OutputFormatter>(new ContainerControlledLifetimeManager())
                .RegisterType<IPrimeGenerator, LinqPrimeGenerator>(new ContainerControlledLifetimeManager())
                .RegisterType<ConsoleReport>(new ContainerControlledLifetimeManager());

            container.Configure<InjectedMembers>().ConfigureInjectionFor<ConsoleReport>(
                new InjectionProperty("MaxNumber", 1000)
                );
        }

        private static void ConfigureContainerUsingXML(UnityContainer container)
        {
            var section = (UnityConfigurationSection) ConfigurationManager.GetSection("unity");
            section.Containers.Default.Configure(container);
        }
    }
}