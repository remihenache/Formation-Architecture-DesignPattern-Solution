namespace BicycleSample.Decorator;

public abstract class BicycleDecorator : IBicycle
{
    private readonly IBicycle _bicycle;

    public BicycleDecorator(IBicycle bicycle)
    {
        _bicycle = bicycle;
    }

    public string ModelName
    {
        get => _bicycle.ModelName;
        set => _bicycle.ModelName = value;
    }

    public virtual void Build()
    {
        _bicycle.Build();
    }
}