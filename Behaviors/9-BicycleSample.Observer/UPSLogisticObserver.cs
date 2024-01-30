namespace BicycleSample.Observer;

public class UPSLogisticObserver : ILogisticObserver
{
    public void NotifyPickupAvailable()
    {
        Console.WriteLine("UPS: Pickup available");
    }
}