namespace BicycleSample.Facade;

public class WelderAPI
{
    public void WeldAtPosition(int x, int y, int z)
    {
        Console.WriteLine($"Welding at position {x}, {y}, {z}");
    }
}