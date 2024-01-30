namespace BicycleSample.Builder;

public class MountainBikeBuilder : IBicycleBuilder
{
    private readonly Bicycle _bicycle = new();

    public void BuildFrame()
    {
        _bicycle.Frame = "Mountain Frame";
    }

    public void BuildHandlebars()
    {
        _bicycle.Handlebars = "Mountain Handlebars";
    }

    public void BuildBrakes()
    {
        _bicycle.Brakes = "Mountain Brakes";
    }

    public void BuildSuspension()
    {
        _bicycle.Suspension = "Road Advanced Suspension";
    }

    public Bicycle Build() => _bicycle;
}