namespace BicycleSample.Builder;

public class Bicycle
{
    public string Frame { get; set; }
    public string Handlebars { get; set; }
    public string Brakes { get; set; }
    public string Suspension { get; set; }

    public void DisplaySpecifications()
    {
        Console.WriteLine($"Frame: {Frame}");
        Console.WriteLine($"Handlebars: {Handlebars}");
        Console.WriteLine($"Brakes: {Brakes}");
        Console.WriteLine($"Suspension: {Suspension}");
    }
}