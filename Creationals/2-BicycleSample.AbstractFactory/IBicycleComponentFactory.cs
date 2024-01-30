using BicycleSample.AbstractFactory.Frames;
using BicycleSample.AbstractFactory.HandleBars;

namespace BicycleSample.AbstractFactory;

public interface IBicycleComponentFactory
{
    IFrames CreateFrame();
    IHandlebars CreateHandlebars();
}