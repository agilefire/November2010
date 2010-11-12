using Primes;
using Spring.Config.Attributes;

namespace SpringApp
{
    [Configuration]
    public class PrimesConfiguration
    {
        [Definition]
        public virtual ConsoleReport ConsoleReport()
        {
            // TODO 4.1 create new ConsoleReport, pass in as arguments the call to the methods below
            return new ConsoleReport(OutputFormatter(), PrimeGenerator()) {MaxNumber = 1000};
        }

        [Definition]
        public virtual IOutputFormatter OutputFormatter()
        {
            // TODO 4.2 create new OutputFormatter
            return new OutputFormatter();
        }

        [Definition]
        public virtual IPrimeGenerator PrimeGenerator()
        {
            // TODO 4.3 create new PrimeGenerator
            return new PrimeGenerator(new PrimeEvaluationEngine());
        }
    }
}