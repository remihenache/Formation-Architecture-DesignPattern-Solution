namespace BicycleSample.Composite;

public abstract class BicycleComponent : IBicycleComponent
{
    protected string componentName;
    protected float cost;

    protected BicycleComponent(string name, float cost)
    {
        componentName = name;
        this.cost = cost;
    }

    public virtual float GetCost() => cost;

    public virtual void DisplayComponentDetails()
    {
        Console.WriteLine($"{componentName}, Cost: {GetCost()}");
    }
}