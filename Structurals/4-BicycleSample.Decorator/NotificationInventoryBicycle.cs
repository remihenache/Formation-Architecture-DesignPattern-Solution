namespace BicycleSample.Decorator;

public class NotificationInventoryBicycle : BicycleDecorator
{
    public NotificationInventoryBicycle(IBicycle bicycle)
        : base(bicycle)
    {
    }

    public override void Build()
    {
        base.Build();
    }
}

public interface INotificationService
{
    void Notify();
}