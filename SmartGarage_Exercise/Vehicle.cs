using System;
namespace SmartGarage_Exercise;
public abstract class Vehicle
{
    public string ModelName { get; set; }
    public Vehicle(string model)
    {
        ModelName = model;
    }
    public abstract void Drive();
    public abstract void MoveLeft();
    public abstract void MoveRight();
}
