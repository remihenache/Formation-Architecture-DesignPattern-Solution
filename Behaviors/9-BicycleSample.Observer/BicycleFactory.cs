namespace BicycleSample.Observer;

public class BicycleFactory
{
    private readonly List<Bicycle> bicycles = new();
    private readonly List<ILogisticObserver> observers = new();

    public void AddObserver(ILogisticObserver observer)
    {
        observers.Add(observer);
    }

    public void DeleteObserver(ILogisticObserver observer)
    {
        observers.Remove(observer);
    }

    public void ProduceBicycle(Bicycle bike)
    {
        bicycles.Add(bike);
        if (bicycles.Count >= 10)
        {
            NotifyObservers();
            bicycles.Clear();
        }
    }

    private void NotifyObservers()
    {
        foreach (ILogisticObserver observer in observers) observer.NotifyPickupAvailable();
    }

    // La méthode pour notifier les observateurs n'est pas encore implémentée
}