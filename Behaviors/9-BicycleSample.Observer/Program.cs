namespace BicycleSample.Observer;

public class Program
{
    public static void Main(string[] args)
    {
        var factory = new BicycleFactory();
        factory.AddObserver(new ExFedLogisticObserver());
        factory.AddObserver(new UPSLogisticObserver());
        for (var i = 0; i < 15; i++) factory.ProduceBicycle(new Bicycle());
        // Actuellement, il n'y a pas de logique pour gérer le nombre minimum de vélos pour le ramassage
    }
}