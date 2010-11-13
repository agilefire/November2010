using NUnit.Framework;

namespace Primes.Tests.Generator
{
    [TestFixture]
    public class When_Calculating_Range_Of_Primes
    {
        [Test]
        public void Should_Return_Values_Comma_Delimited()
        {
            var primeGenerator = new PrimeGenerator(new PrimeEvaluationEngine());

            var actual = primeGenerator.GeneratePrimesUpTo(10);

			Assert.That(actual, Is.EqualTo("2,3,5,7,9"));
        }
    }
}