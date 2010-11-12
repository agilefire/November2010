using System.Text;

namespace Primes
{
    public class PrimeGenerator 
    {
        private readonly PrimeEvaluationEngine _primeEvaluationEngine;

        public PrimeGenerator(PrimeEvaluationEngine primeEvaluationEngine)
        {
            _primeEvaluationEngine = primeEvaluationEngine;
        }

        public string GeneratePrimesUpTo(int max)
        {
            var stringBuilder = new StringBuilder();

            for (var candidate = 0; candidate < max; candidate++)
            {
            	if (!_primeEvaluationEngine.IsPrime(candidate))
					continue;

            	stringBuilder.Append(candidate.ToString());
            	stringBuilder.Append(",");
            }

            var theString = stringBuilder.ToString();

            if (theString.Contains(","))
                theString = theString.Remove(theString.LastIndexOf(","));

            return theString;
        }
    }
}