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
        	return string.Empty;
        }
    }
}