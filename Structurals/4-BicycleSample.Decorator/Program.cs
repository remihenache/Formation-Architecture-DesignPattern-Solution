namespace BicycleSample.Decorator;

internal class Program
{
    private static void Main()
    {
        IBicycle roadBike = new NotificationInventoryBicycle(new RoadBike());
        roadBike.Build();


        IBicycle mountainBike = new DocumentedBicycle(new MountainBike());
        mountainBike.Build();

        IBicycle roadBikeWithDocumentation =
            new DocumentedBicycle(new NotificationInventoryBicycle(new RoadBike()));
        roadBikeWithDocumentation.Build();
    }
}