using Primes;

using Spring.Context.Attributes;

namespace SpringApp
{
    [Configuration]
    public class PrimesConfiguration
    {
        [Definition]
        public virtual ConsoleReport ConsoleReport()
        {
            // TODO Spring - 2.0 - Create new ConsoleReport, see spring-slides.pdf for assistance in the DI folder
            //                     but this is 'just plain code'!
            //          a. Pass in as constructor arguments calls to ConsoleReport constructor
            //             the OutputFormatter() and PrimeGenerator() methods defined in this class.
            //          b. Set the MaxNumber property on ConsoleReport to 1000;
            //          c. return created ConsoleReport instance.
            return null;
        }

        [Definition]
        public virtual IOutputFormatter OutputFormatter()
        {
            return new OutputFormatter();
        }

        [Definition]
        public virtual IPrimeGenerator PrimeGenerator()
        {
            return new PrimeGenerator(new PrimeEvaluationEngine());
        }
    }
}