using NUnit.Framework;

namespace Primes.Tests.Formatter
{
    [TestFixture]
    public class When_Formatting_Output
    {
        private string _generatedPrimes;

        [TestFixtureSetUp]
        public void _TestFixtureSetUp()
        {
            _generatedPrimes = new PrimeGenerator(new PrimeEvaluationEngine()).GeneratePrimesUpTo(20);
        }

        [Test]
        public void Should_Return_Collection_of_Output_Lines()
        {
            var outputFormatter = new OutputFormatter();

            var formattedOutput = outputFormatter.Format(_generatedPrimes);

			Assert.That(formattedOutput, Is.Not.Empty);
        }

        [Test]
		public void Should_Have_No_More_Than_Five_Items_For_Each_Output_Line()
        {
            var outputFormatter = new OutputFormatter();

            var formattedOutput = outputFormatter.Format(_generatedPrimes);

            string[] splitPrimes;

            foreach (var item in formattedOutput)
            {
                splitPrimes = item.Split(",".ToCharArray());

                Assert.That(splitPrimes.Length, Is.LessThanOrEqualTo(5));
            }
        }

        [Test]
        public void Should_Contains_Count_For_Every_Tenth_Line()
        {
            var generatedPrimes = new PrimeGenerator(new PrimeEvaluationEngine()).GeneratePrimesUpTo(2000);

            var outputFormatter = new OutputFormatter();

            var formattedOutput = outputFormatter.Format(generatedPrimes);

            for (var i = 10; i < formattedOutput.Count; i += 11)
            {
                Assert.That(formattedOutput[i].Contains("Count:"));
            }
        }
    }
}