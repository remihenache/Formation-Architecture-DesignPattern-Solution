namespace BicycleSample.Facade;

public class GripperAPI
{
    public void GripAtPosition(int x, int y)
    {
        Console.WriteLine($"Gripping at position {x}, {y}");
    }
}