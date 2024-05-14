public class IntercityBus:Bus
{
    private string scheduleIdentifier;
    public override BusType GetBusType => BusType.Intercity;
    
    public IntercityBus(string licensePlate, double fuelConsumptionPer100Km, int numberOfSeats, string scheduleIdentifier): base(licensePlate, fuelConsumptionPer100Km, numberOfSeats)
    {
        this.scheduleIdentifier = scheduleIdentifier;
    }
    
    public new void Ride()
    {
        Console.WriteLine($"Riding a {this.GetBusType} bus");
    }
    
    public override string GetScheduleIdentifier()
    {
        return scheduleIdentifier;
    }
}