namespace BicycleSample.Composite;

public class HandlebarComposite : BicycleComponent
{
    private List<BicycleComponent> subComponents = new List<BicycleComponent>();

    public HandlebarComposite() : base("Handlebar", 200) { } // prix fixe pour le guidon

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