public abstract class Bus
{
    public string LicensePlate { get; set; }
    public double FuelConsumptionPer100Km { get; set; }
    public int NumberOfSeats { get; set; }
    public abstract BusType GetBusType { get; }

    protected Bus(string licensePlate, double fuelConsumptionPer100Km, int numberOfSeats)
    {
        LicensePlate = licensePlate;
        FuelConsumptionPer100Km = fuelConsumptionPer100Km;
        NumberOfSeats = numberOfSeats;
    }

    public abstract string GetScheduleIdentifier();

    public void Print()
    {
        Console.WriteLine(GetBusType+" "+LicensePlate+" "+FuelConsumptionPer100Km+" "+NumberOfSeats);
    }

    public Bus Ride()
    {
        Console.WriteLine("Riding a bus");
        return this;
    }
}