namespace BicycleSample.Factory;

public interface IBicycleFactory
{
    Bicycle CreateBicycle(string name);
}