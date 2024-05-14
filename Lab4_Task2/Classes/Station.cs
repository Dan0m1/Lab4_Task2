public class Station
{
    private List<Bus> _buses;

    public Station(List<Bus> buses)
    {
        _buses = buses;
    }

    public int CountBuses()
    {
        return _buses.Count;
    }

    public void SortByPlaces()
    {
        _buses = _buses.OrderBy(bus => bus.NumberOfSeats).ToList();
    }

    public List<Bus> FindByConsumption(double fuelConsumption)
    {
        return _buses.Where(bus => bus.FuelConsumptionPer100Km == fuelConsumption).ToList();
    }

    public Bus FindByLicensePlate(string plate)
    {
        return _buses.Find(bus => bus.LicensePlate.Equals(plate));
    }
}