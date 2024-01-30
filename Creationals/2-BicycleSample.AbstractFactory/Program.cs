// See https://aka.ms/new-console-template for more information

using BicycleSample.AbstractFactory.Frames;
using BicycleSample.AbstractFactory.HandleBars;

namespace BicycleSample.AbstractFactory;

internal class Program
{
    private static void Main(string[] args)
    {
        // Exemple d'utilisation de la factory
        IBicycleComponentFactory bikeComponentFactory = new RoadBikeComponentFactory();
        IFrames roadBikeFrame = bikeComponentFactory.CreateFrame();
        IHandlebars roadBikeHandlebars = bikeComponentFactory.CreateHandlebars();

        bikeComponentFactory = new MountainBikeComponentFactory();
        IHandlebars mountainBikeHandlebars = bikeComponentFactory.CreateHandlebars();

        Console.WriteLine(roadBikeFrame.FrameType);
        Console.WriteLine(mountainBikeHandlebars.HandlebarsType);
    }
}