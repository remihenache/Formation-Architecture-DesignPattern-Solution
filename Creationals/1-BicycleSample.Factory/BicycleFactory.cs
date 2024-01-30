using System;
using BicycleSample.Factory.Bicycles;

namespace BicycleSample.Factory;

public class BicycleFactory : IBicycleFactory
{
    public Bicycle CreateBicycle(string name)
    {
        Bicycle bikeToBuild;
        switch (name)
        {
            case "mountainbike":
                bikeToBuild = new MountainBike();
                break;
            case "cruiser":
                bikeToBuild = new Cruiser();
                break;
            default:
                throw new Exception("Unknown bicycle type: " +
                                    name);
        }

        return bikeToBuild;
    }
}