using NUnit.Framework;
using NUnit.Framework.SyntaxHelpers;

namespace Primes.Tests.EvaluationEngine
{
    [TestFixture]
    public class When_Candidate_Is_Negative
    {
        [Test]
        public void Should_Return_False()
        {
            var primeEvaluationEngine = new PrimeEvaluationEngine();

            Assert.That(primeEvaluationEngine.IsPrime(-1), Is.False);
        }
    }
}