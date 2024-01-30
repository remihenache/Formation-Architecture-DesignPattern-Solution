namespace BicycleSample.Decorator;

public class RoadBike : IBicycle
{
    public string ModelName { get; set; } = "Road Bike";

    public void Build()
    {
        Console.WriteLine($"Building {ModelName}");
    }
}