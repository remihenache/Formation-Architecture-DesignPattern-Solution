using BicycleSample.AbstractFactory.Frames;
using BicycleSample.AbstractFactory.HandleBars;

namespace BicycleSample.AbstractFactory;

public class RoadBikeComponentFactory : IBicycleComponentFactory
{
    public IFrames CreateFrame() => new RoadBikeFrame();
    public IHandlebars CreateHandlebars() => new RoadBikeHandlebars();
}