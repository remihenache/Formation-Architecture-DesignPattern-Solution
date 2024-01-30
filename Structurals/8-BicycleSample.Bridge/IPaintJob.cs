namespace BicycleSample.Bridge;

// Interface représentant le travail de peinture
public interface IPaintJob
{
    BicyclePaintColors ApplyPaint();
}

public class RedPaintJob : IPaintJob
{
    public BicyclePaintColors ApplyPaint() => BicyclePaintColors.Red;
}