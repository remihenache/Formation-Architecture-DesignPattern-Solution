using BicycleSample.AbstractFactory.Frames;
using BicycleSample.AbstractFactory.HandleBars;

namespace BicycleSample.AbstractFactory;

public class MountainBikeComponentFactory : IBicycleComponentFactory
{
    public IFrames CreateFrame() => new MountainBikeFrame();
    public IHandlebars CreateHandlebars() => new MountainBikeHandlebars();
}