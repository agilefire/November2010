using System;

namespace MileageCalculator
{
	public class Calculator
	{
		public double Milage(FuelType fuelType)
		{
			switch (fuelType)
			{
				case FuelType.Gas:
				case FuelType.Disel:
				case FuelType.Hybrid:
					var ecu = new EngineControlUnit();
					return ecu.TripDistance / ecu.FuelConsumed;

				case FuelType.Electric:
					var electricEcu = new ElectricEngineControlUnit();
					return (electricEcu.TripDistance / electricEcu.EnergyConsumed) * electricEcu.FuelConversionFactor;

				case FuelType.FuelCell:
					var fuelCellEcu = new FuelCellEngineControlUnit();
					return (fuelCellEcu.TripDistance / fuelCellEcu.FuelConsumed) * fuelCellEcu.FuelConversionFactor;
			}

			throw new ArgumentException(string.Format("Can't calculate this fuel type: {0}", fuelType), "fuelType");
		}
	}
}
