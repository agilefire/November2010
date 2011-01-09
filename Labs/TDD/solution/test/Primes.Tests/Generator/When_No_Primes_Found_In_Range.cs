﻿using NUnit.Framework;

namespace Primes.Tests.Generator
{
    [TestFixture]
    public class When_No_Primes_Found_In_Range
    {
        [Test]
        public void Should_Return_Empty_String()
        {
            var primeGenerator = new PrimeGenerator(new PrimeEvaluationEngine());

            Assert.That(primeGenerator.GeneratePrimesUpTo(0), Is.EqualTo(string.Empty));
        }
    }
}