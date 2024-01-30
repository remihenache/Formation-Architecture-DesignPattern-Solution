namespace BicycleSample.Builder;

public class Director
{
    public Bicycle Construct(IBicycleBuilder builder, bool WithSuspension = false)
    {
        builder.BuildFrame();
        builder.BuildHandlebars();
        builder.BuildBrakes();
        if (WithSuspension)
            builder.BuildSuspension();
        return builder.Build();
    }
}