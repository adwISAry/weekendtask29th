namespace weekendtask29th
{
    public interface IEngine
    {
        int HorsePower { get; set; }
        int TankSize { get; set; }
        int CurrentOil { get; set; }
        string FuelType { get; set; }

        int RemainOilAmount();
    }
    public interface IWheel
    {
        int WheelThickness { get; set; }
    }
    public  interface ITransmission
    {
        string TransmissionKind { get; set; }   
    }

}

