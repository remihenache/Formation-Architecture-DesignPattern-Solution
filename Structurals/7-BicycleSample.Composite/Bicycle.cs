namespace BicycleSample.Composite;

public class Bicycle : BicycleComponent
{
    private readonly List<BicycleComponent> components = new List<BicycleComponent>();

    public Bicycle() : base("Bicycle", 0) { }

    public void AddComponent(BicycleComponent component)
    {
        components.Add(component);
    }

    public override float GetCost()
    {
        float totalCost = 0;
        foreach (var component in components)
        {
            totalCost += component.GetCost();
        }
        return totalCost;
    }

    public override void DisplayComponentDetails()
    {
        Console.WriteLine($"{componentName}, Total Cost: {GetCost()}");
        foreach (var component in components)
        {
            component.DisplayComponentDetails();
        }
    }
}