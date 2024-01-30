namespace BicycleSample.Composite;

public class WheelComposite : BicycleComponent
{
    private List<BicycleComponent> subComponents = new List<BicycleComponent>();

    public WheelComposite() : base("Wheel", 300) { } // prix fixe pour la roue

    public void AddComponent(BicycleComponent component)
    {
        subComponents.Add(component);
    }

    public override float GetCost()
    {
        float totalCost = cost;
        foreach (var component in subComponents)
        {
            totalCost += component.GetCost();
        }
        return totalCost;
    }

    public override void DisplayComponentDetails()
    {
        Console.WriteLine($"{componentName}, Cost: {GetCost()}");
        foreach (var component in subComponents)
        {
            component.DisplayComponentDetails();
        }
    }
}