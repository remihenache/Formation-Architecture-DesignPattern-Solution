namespace BicycleSample.Decorator;

public class MountainBike : IBicycle
{
    public string ModelName { get; set; } = "Mountain Bike";

    public void Build()
    {
        Console.WriteLine($"Building {ModelName}");
    }
}