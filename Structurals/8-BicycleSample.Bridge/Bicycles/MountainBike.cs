namespace BicycleSample.Bridge.Bicycles;

public class MountainBike : Bicycle
{
    public MountainBike(IPaintJob paintJob) : base(paintJob)
    {
        ModelName = "Palo Duro Canyon Ranger";
        Suspension = SuspensionTypes.Full;
        Geometry = BicycleGeometries.Upright;
    }
}