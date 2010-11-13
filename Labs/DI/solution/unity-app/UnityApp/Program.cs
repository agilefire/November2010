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
                //TODO Unity - 3.0 - Call ConfigureContainerUsingXML instead of ConfigureContainerUsingAPI and run project
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
            // TODO Unity - 1.0 - Use configuration api to configure the primes application.  See slide 24 in presentation 

            // TODO Unity - 2.0 - Switch from PrimeGenerator to use LinqPrimeGenerator instead
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