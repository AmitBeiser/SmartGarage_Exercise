using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartGarage_Exercise
{
	public static class SmartGarageTester
	{
		public static void TestAllVehicles(Vehicle[] allVehicles)
		{
			Console.WriteLine("\n--- Commencing Vehicle diagnostics ---");
			foreach (var v in allVehicles)
			{
				Console.WriteLine($"-- Testing {v.ModelName} --");
				v.Drive();
				if (v is FuelVehicle fv)
				{
					fv.Refuel();
				}
			}
		}
		public static void TestMovablesAndChargeables(IMovable[] movables)
		{
			Console.WriteLine("\n--- Commencing Movable/Chargeable test ---");

			foreach (var m in movables)
			{
				m.MoveRight();
				if (m is IChargeable chargeable)
				{
					chargeable.ChargeBattery();
				}
			}

			Console.WriteLine("--- Movable/Chargeable test complete ---");
		}
	}
}
