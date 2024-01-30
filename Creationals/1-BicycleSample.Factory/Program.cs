using System;

namespace BicycleSample.Factory;

public class Program
{
    private const string errorText = "You must pass in mountainbike, cruiser, recumbent, or roadbike";

    public static void Main(string[] args)
    {
        if (args.Length > 0)
        {
            string bicycleType = args[0].Trim().ToLower();
            IBicycleFactory factory = new BicycleFactory();
            Bicycle bikeToBuild = factory.CreateBicycle(bicycleType);
            bikeToBuild.Build();
        }
        else
        {
            Console.WriteLine(errorText);
        }
    }
}