namespace BicycleSample.Builder;

public class RoadBikeBuilder : IBicycleBuilder
{
    private readonly Bicycle _bicycle = new();

    public void BuildFrame()
    {
        _bicycle.Frame = "Road Frame";
    }

    public void BuildHandlebars()
    {
        _bicycle.Handlebars = "Road Handlebars";
    }

    public void BuildBrakes()
    {
        _bicycle.Brakes = "Road Standard Brakes";
    }

    public void BuildSuspension()
    {
        _bicycle.Suspension = "Road Standard Suspension";
    }

    public Bicycle Build() => _bicycle;
}