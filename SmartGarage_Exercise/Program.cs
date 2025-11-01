namespace SmartGarage_Exercise
{
    internal class Program
    {
        static void Main(string[] args)
        {
			Console.WriteLine("--- Welcome to Smart Garage (v1.0 - Messy) ---");
			Car car1 = new Car("Subaru Impreza", 20);
			Motorcycle bike1 = new Motorcycle("Kawasaki Ninja", 40);
			CleaningRobot robot1 = new CleaningRobot("S-500", 15);
			Drone drone1 = new Drone();
			Vehicle[] allVehicles = { car1, bike1 };
			IMovable[] allMovables = { car1, bike1, robot1, drone1 };
			SmartGarageTester.TestAllVehicles(allVehicles);
			SmartGarageTester.TestMovablesAndChargeables(allMovables);
			robot1.StartCleaning();
			drone1.Fly();
		}
	}

}
    

