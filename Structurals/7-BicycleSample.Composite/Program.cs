using BicycleSample.Composite.Components;

namespace BicycleSample.Composite;

internal class Program
{
    private static void Main()
    {
        var bike = new Bicycle();

        var handlebar = new HandlebarComposite();
        handlebar.AddComponent(new Grip());
        handlebar.AddComponent(new Bell());

        var wheel = new WheelComposite();
        wheel.AddComponent(new BrakePad());

        bike.AddComponent(handlebar);
        bike.AddComponent(wheel);
        bike.AddComponent(new Frame()); // Ajouter le cadre comme composant simple

        bike.DisplayComponentDetails();
    }
}