using Newtonsoft.Json;
class Program
{
    public static void Main()
    {
        List<Bus> buses = new List<Bus>();
        string dataFolder = "C:\\Users\\servo\\RiderProjects\\Lab4_Task2\\Lab4_Task2\\Input\\";
        buses.AddRange(JsonConvert.DeserializeObject<List<SuburbanBus>>(GetInput(dataFolder+"suburban.json")));
        buses.AddRange(JsonConvert.DeserializeObject<List<UrbanBus>>(GetInput(dataFolder+"urban.json")));
        buses.AddRange(JsonConvert.DeserializeObject<List<IntercityBus>>(GetInput(dataFolder+"intercity.json")));

        Station station = new Station(buses);
        station.SortByPlaces();
        Console.WriteLine(station.CountBuses());

        List<Bus> consumption = station.FindByConsumption(18.5);
        foreach (Bus bus in consumption)
        {
            bus.Ride().Print();
        }

        station.FindByLicensePlate("AA0001AB").Ride().Print();
    }

    public static string GetInput(string dataLoc)
    {
        string input;
        using (StreamReader reader = new StreamReader(dataLoc))
        {
            input = reader.ReadToEnd();
        }

        if (input == null)
        {
            Console.WriteLine("JSON file is empty");
            return "";
        }

        return input;
    }
}