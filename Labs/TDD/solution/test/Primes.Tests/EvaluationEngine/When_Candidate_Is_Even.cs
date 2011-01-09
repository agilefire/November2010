using NUnit.Framework;

namespace Primes.Tests.EvaluationEngine
{
    [TestFixture]
    public class When_Candidate_Is_Even
    {
        [Test]
        public void Should_Return_False()
        {
            var primeEvaluationEngine = new PrimeEvaluationEngine();

            Assert.That(primeEvaluationEngine.IsPrime(8), Is.False);
        }
    }
}