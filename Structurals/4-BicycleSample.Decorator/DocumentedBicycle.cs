namespace BicycleSample.Decorator;

public class DocumentedBicycle : BicycleDecorator
{
    public DocumentedBicycle(IBicycle bicycle)
        : base(bicycle)
    {
    }

    public override void Build()
    {
        base.Build();
        Console.WriteLine("Documenting the bicycle build.");
    }
}