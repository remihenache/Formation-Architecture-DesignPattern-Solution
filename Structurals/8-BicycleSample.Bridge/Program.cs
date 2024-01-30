using BicycleSample.Bridge.Bicycles;

namespace BicycleSample.Bridge;

internal class Program
{
    private static void Main()
    {
        // Utilisation
        var bicycle1 = new Cruiser(new RedPaintJob());
        bicycle1.Build();
    }
}