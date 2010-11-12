using System;
using Primes;

namespace PrimesApp
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            var primeGenerator = new PrimeGenerator(new PrimeEvaluationEngine());

            var results = new OutputFormatter().Format(primeGenerator.GeneratePrimesUpTo(10000));
			results.ForEach(Console.WriteLine);

            Console.WriteLine("--- hit enter to exit --");
            Console.ReadLine();
        }
    }
}