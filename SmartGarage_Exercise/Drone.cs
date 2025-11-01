using System;
namespace SmartGarage_Exercise;
public class Drone : IMovable, IChargeable
{
    public int BatteryPercentage { get; set; }
    public Drone()
    {
        BatteryPercentage = 100;
    }
    public void Fly()
    {
        Console.WriteLine("Drone is flying...");
        if (BatteryPercentage > 0)
            BatteryPercentage = Math.Max(0, BatteryPercentage - 10);
    }
    public void ChargeBattery()
    {
        Console.WriteLine("Drone is charging...");
        BatteryPercentage = 100;
    }
    public void MoveLeft()
    {
        Console.WriteLine("Drone moves left.");
    }
    public void MoveRight()
    {
        Console.WriteLine("Drone moves right.");
    }
}
