using MileageCalculator;
using NUnit.Framework;

namespace MilageCalculatorTest
{
	[TestFixture]
	public class CalculatorTest
	{
		[Test]
		public void Should_calculate_gas_milage_from_distance_travelled_and_fuel_consumed()
		{
			// Arrange
			var calculator = new Calculator();

			// Act
			var milage = calculator.Milage(FuelType.Gas);

			// Assert
			const int huh = -1;
			Assert.That(milage, Is.EqualTo(huh));
		}
	}
}