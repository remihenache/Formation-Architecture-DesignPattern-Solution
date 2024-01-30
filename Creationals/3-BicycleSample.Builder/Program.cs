namespace BicycleSample.Builder;

// Une factory simple pour construire un vélo

internal class Program
{
    private static void Main(string[] args)
    {
        var director = new Director();
        Bicycle bicycle = director.Construct(new RoadBikeBuilder());
        bicycle.DisplaySpecifications();
    }
}