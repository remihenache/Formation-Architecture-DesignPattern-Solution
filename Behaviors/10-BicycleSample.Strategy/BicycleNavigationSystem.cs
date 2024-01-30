namespace BicycleSample.Strategy;

public class BicycleNavigationSystem
{
    private readonly NavigationSystem navigationSystem;

    public BicycleNavigationSystem(NavigationSystem navigationSystem)
    {
        this.navigationSystem = navigationSystem;
    }

    public string CalculateRoute() => navigationSystem.CalculateRoute();
}