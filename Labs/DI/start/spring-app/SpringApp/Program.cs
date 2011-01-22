using System;
using Primes;
using Spring.Context;
using Spring.Context.Support;
using Spring.Objects.Factory.Config;
using Spring.Objects.Factory.Support;

namespace SpringApp
{
    class Program
    {
        private static IObjectDefinitionFactory definitionFactory = new DefaultObjectDefinitionFactory();

        static void Main(string[] args)
        {
            // TODO Spring - 1.0 - Set SpringApp as the startup project and run.  Look at the configuration in application-context.xml
                        
            // TODO Spring - 3.0 - Run the SpringApp console application

            // TODO Spring - 4.0 - Switch to use XML instead of Code to configure the container.
            //                     Go into the file application-context.xml and follow the TODOs there.
            
            // TODO Spring - 5.0 - Instead of calling CreateContainerUsingCodeConfig() call CreateContainerUsingXML() and run SpringApp console application
            
            // TODO Spring - 6.1 - Run the SpringApp console application with appliation-context-autowire.xml
            IApplicationContext ctx = CreateContainerUsingCodeConfig();

            ConsoleReport report = ctx["ConsoleReport"] as ConsoleReport;
            report.Write();

            ctx.Dispose();

            Console.WriteLine("--- hit enter to exit --");
            Console.ReadLine();
        }

        
        private static IApplicationContext CreateContainerUsingXML()
        {
            //TODO Spring - 6.0 - Change to use appliation-context-autowire.xml
            return new XmlApplicationContext("application-context.xml");
        }

        private static IApplicationContext CreateContainerUsingCodeConfig()
        {
            ScanningApplicationContext ctx = new ScanningApplicationContext();
            ctx.Scan();
            ctx.Refresh();
            return ctx;
        }
    }
}
