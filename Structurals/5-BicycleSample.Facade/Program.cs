namespace BicycleSample.Facade;

public class RobotArmFacade
{
    private readonly BufferAPI _buffer;
    private readonly GripperAPI _gripper;
    private readonly WelderAPI _welder;

    public RobotArmFacade()
    {
        _welder = new WelderAPI();
        _buffer = new BufferAPI();
        _gripper = new GripperAPI();
    }

    public void WeldAtPosition(int x, int y, int z)
    {
        _welder.WeldAtPosition(x, y, z);
    }

    public void BuffAtPosition(int x, int y)
    {
        _buffer.BuffAtPosition(x, y);
    }

    public void GripAtPosition(int x, int y)
    {
        _gripper.GripAtPosition(x, y);
    }

    public void MoveArmToCreateFrame()
    {
        WeldAtPosition(10, 20, 30);
        BuffAtPosition(15, 25);
        GripAtPosition(5, 10);
    }
}

internal class Program
{
    private static void Main()
    {
        var robotArm = new RobotArmFacade();

        robotArm.MoveArmToCreateFrame();

        robotArm.WeldAtPosition(10, 20, 30);
        robotArm.BuffAtPosition(15, 25);
        robotArm.GripAtPosition(5, 10);
    }
}