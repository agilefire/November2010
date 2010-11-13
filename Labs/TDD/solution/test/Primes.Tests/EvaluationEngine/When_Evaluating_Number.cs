using NUnit.Framework;

namespace Primes.Tests.EvaluationEngine
{
    [TestFixture]
    public class When_Evaluating_Number
    {
        private const int NON_PRIME_TEST_VALUE = 35;

        private const int PRIME_TEST_VALUE = 17;

        [Test]
        public void Should_Return_True_For_Prime()
        {
            var primeEvaluationEngine = new PrimeEvaluationEngine();

            Assert.That(primeEvaluationEngine.IsPrime(PRIME_TEST_VALUE), Is.True);
        }

        [Test]
        public void Should_Return_False_For_Non_Prime()
        {
            var primeEvaluationEngine = new PrimeEvaluationEngine();

            Assert.That(primeEvaluationEngine.IsPrime(NON_PRIME_TEST_VALUE), Is.False);
        }
    }
}