namespace BicycleSample.Observer;

public class ExFedLogisticObserver : ILogisticObserver
{
    public void NotifyPickupAvailable()
    {
        Console.WriteLine("ExFed: Pickup available");
    }
}