using NUnit.Framework;

namespace Primes.Tests.EvaluationEngine
{
    [TestFixture]
    public class When_Candidate_Is_Two
    {
        [Test]
        public void Should_Return_True()
        {
            var primeEvaluationEngine = new PrimeEvaluationEngine();

            Assert.That(primeEvaluationEngine.IsPrime(2), Is.True);
        }
    }
}