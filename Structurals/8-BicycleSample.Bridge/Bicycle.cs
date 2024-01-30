namespace BicycleSample.Bridge;

public abstract class PaintableBicycle
{
    private readonly IPaintJob _paintJob;

    public PaintableBicycle(IPaintJob paintJob)
    {
        _paintJob = paintJob;
    }

    protected BicyclePaintColors Color { get; set; }

    public virtual void Build()
    {
        Color = _paintJob.ApplyPaint();
    }
}

public class Bicycle : PaintableBicycle
{
    public Bicycle(IPaintJob paintJob) : base(paintJob)
    {
        ModelName = string.Empty;
        SerialNumber = Guid.NewGuid().ToString();
        Year = DateTime.Now.Year;
        BuildStatus = ManufacturingStatus.Specified;
    }

    protected string ModelName { get; init; }
    private int Year { get; }
    private string SerialNumber { get; }
    protected BicycleGeometries Geometry { get; init; }
    protected SuspensionTypes Suspension { get; init; }
    private ManufacturingStatus BuildStatus { get; set; }

    public override void Build()
    {
        base.Build();
        Console.WriteLine($"Manufacturing a {Geometry.ToString()} frame...");
        BuildStatus = ManufacturingStatus.FrameManufactured;
        PrintBuildStatus();

        Console.WriteLine($"Painting the frame {Color.ToString()}");
        BuildStatus = ManufacturingStatus.Painted;
        PrintBuildStatus();

        if (Suspension != SuspensionTypes.Hardtail)
        {
            Console.WriteLine($"Mounting the {Suspension.ToString()} suspension.");
            BuildStatus = ManufacturingStatus.SuspensionMounted;
            PrintBuildStatus();
        }

        Console.WriteLine("{0} {1} Bicycle serial number {2} manufacturing complete!", Year, ModelName, SerialNumber);
        BuildStatus = ManufacturingStatus.Complete;
        PrintBuildStatus();
    }

    private void PrintBuildStatus()
    {
        Console.WriteLine($"Current build status: {BuildStatus.ToString()}");
    }
}