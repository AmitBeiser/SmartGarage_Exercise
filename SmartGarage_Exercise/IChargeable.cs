using System;
namespace SmartGarage_Exercise;
public interface IChargeable
{
    public int BatteryPercentage
    {
        get; set;
    }
    public void ChargeBattery();
}
