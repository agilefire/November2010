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
                        
            // TODO Spring - 2.0 - Instead of calling CreateContainerUsingXML, call CreateContainerUsingCodeConfig.
            IApplicationContext ctx = CreateContainerUsingXML();

            ConsoleReport report = ctx["ConsoleReport"] as ConsoleReport;
            report.Write();

            ctx.Dispose();

            Console.WriteLine("--- hit enter to exit --");
            Console.ReadLine();
        }

        
        private static IApplicationContext CreateContainerUsingXML()
        {
            return new XmlApplicationContext("application-context-explicit.xml");
        }

        private static IApplicationContext CreateContainerUsingCodeConfig()
        {
            return new XmlApplicationContext("application-context-code-config.xml");
        }

        #region Using Lower Level APIs - not required for lab exercise...but if you are curious...
        private static IApplicationContext CreateContainerUsingBuilderAPI()
        {
            var ctx = new GenericApplicationContext();

            var builder = GetBuilder<ConsoleReport>();
            builder.AddPropertyValue("MaxNumber", 1000); 
            ctx.RegisterObjectDefinition("ConsoleReport", builder.ObjectDefinition);

            ctx.RegisterObjectDefinition("PrimeGenerator", GetBuilder<PrimeGenerator>().ObjectDefinition);
            ctx.RegisterObjectDefinition("OutputFormatter", GetBuilder<OutputFormatter>().ObjectDefinition);
            ctx.RegisterObjectDefinition("PrimeEvaluationEngine", GetBuilder<PrimeEvaluationEngine>().ObjectDefinition);

            ctx.Refresh();

            return ctx;

        }

        private static ObjectDefinitionBuilder GetBuilder<T>()
        {
            return ObjectDefinitionBuilder.RootObjectDefinition(definitionFactory, typeof(T)).SetAutowireMode(AutoWiringMode.AutoDetect);
        }
        #endregion 
    }
}
