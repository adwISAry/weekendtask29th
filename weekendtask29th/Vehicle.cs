using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace weekendtask29th
{
    internal abstract class Vehicle
    {
        public int DriveTime { get; set; }
        public int DrivePath { get; set; }

        public virtual int AverageSpeed()
        {
            if (DriveTime <= 0 ) 
            {
                Console.WriteLine("Not Possible, Drive time cant be 0 or less!");
            }
            return DrivePath / DriveTime;
        }
    }
    internal class Car: Vehicle, IEngine, ITransmission, IWheel
    {
        public int DoorCount {  get; set; }
        public int WinCode { get; set;}

        public int HorsePower { get; set; }
        public int TankSize { get; set; }
        public int CurrentOil { get; set; }
        public string FuelType { get; set; }
        public int WheelThickness { get; set; }

        public int RemainOilAmount()
        {
            return TankSize - CurrentOil;
        }
        public string TransmissionKind { get; set; }

        public override string ToString()
        {
            return $"Car Information:\n" +
           $"- Door Count: {DoorCount}\n" +
           $"- Win Code: {WinCode}\n" +
           $"- Horse Power: {HorsePower}\n" +
           $"- Tank Size: {TankSize}\n" +
           $"- Current Oil: {CurrentOil}\n" +
           $"- Fuel Type: {FuelType}\n" +
           $"- Wheel Thickness: {WheelThickness}";
        }

    }
    internal class Bicycle : Vehicle, IWheel
    {
        public string PedalKind { get; set; }

        public int WheelThickness { get; set; }
        public override string ToString()
        {
            return $"Bicycle Information:\n" +
           $"- Pedal Kind: {PedalKind}\n" +
           $"- Wheel Thickness: {WheelThickness}";
        }

    }
    internal class Plane : Vehicle, IEngine
    {
        public int WingLength {  get; set; }
        public int HorsePower { get; set; }
        public int TankSize { get; set; }
        public int CurrentOil { get; set; }
        public string FuelType { get; set; }
        public int RemainOilAmount()
        {
            return TankSize - CurrentOil;
        }
        public override string ToString()
        {
            return $"Plane Information:\n" +
           $"- Wing Length: {WingLength}\n" +
           $"- Horse Power: {HorsePower}\n" +
           $"- Tank Size: {TankSize}\n" +
           $"- Current Oil: {CurrentOil}\n" +
           $"- Fuel Type: {FuelType}";
        }
    }
}


