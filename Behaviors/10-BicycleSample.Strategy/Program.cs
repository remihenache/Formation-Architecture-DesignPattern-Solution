namespace BicycleSample.Strategy;

public class Program
{
    public static void Main(string[] args)
    {
        var navigationSystem = new BicycleNavigationSystem(new RoadNavigationSystem());
        Console.WriteLine(navigationSystem.CalculateRoute());

        // Testez avec différents types de terrain
    }
}