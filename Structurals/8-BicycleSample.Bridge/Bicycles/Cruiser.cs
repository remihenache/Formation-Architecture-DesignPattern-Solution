namespace BicycleSample.Bridge.Bicycles;

public class Cruiser : Bicycle
{
    public Cruiser(IPaintJob paintJob) : base(paintJob)
    {
        ModelName = "Galveston Cruiser";
        Suspension = SuspensionTypes.Hardtail;
        Geometry = BicycleGeometries.Upright;
    }
}