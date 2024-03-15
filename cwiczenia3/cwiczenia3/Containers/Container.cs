using cwiczenia3.Exceptions;
using cwiczenia3.Interfaces;

namespace cwiczenia3.Containers;

public abstract class Container : IContainer
{
    //private double _cargoWeight;
    public double CargoWeight { get; set; }
    public double Height { get; set; }
    public double ContainerWeight { get; set; }
    public double Depth { get; set; }
    public int SerialNumber { get; set; } // KON-C-1
    public double MaxWeight { get; set; }

    protected Container(double cargoWeight, double height, double containerWeight, double depth, int serialNumber, double maxWeight)
    {
        CargoWeight = cargoWeight;
        Height = height;
        ContainerWeight = containerWeight;
        Depth = depth;
        SerialNumber = serialNumber;
        MaxWeight = maxWeight;
    }


    public virtual void Load(double cargoWeight)
    {
        if (cargoWeight > MaxWeight)
        {
            throw new OverfillException();
        }
        
        throw new NotImplementedException();
    }

    public void Unload()
    {
        
        throw new NotImplementedException();
    }
}