namespace BicycleSample.Builder;

public interface IBicycleBuilder
{
    void BuildFrame();
    void BuildHandlebars();
    void BuildBrakes();
    void BuildSuspension();
    Bicycle Build();
}