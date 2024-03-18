
using cwiczenia3.Exceptions;
using cwiczenia3.Interfaces;

namespace cwiczenia3.Containers;

public abstract class Container : IContainer
{
   
    public double CargoWeight { get; set; }
    public double Height { get; set; }
    public double ContainerWeight { get; set; }
    public double Depth { get; set; }
    public string SerialNumber { get; set; } // KON-C-1
    public double MaxWeight { get; set; }
    public  int Number { get; set; }
    public static int Counter = 0;
    public char Letter  { get; set; }

    protected Container(double cargoWeight, double height, double containerWeight, double depth, double maxWeight)
    {
        CargoWeight = cargoWeight;
        Height = height;
        ContainerWeight = containerWeight;
        Depth = depth;
        MaxWeight = maxWeight;
        Number=Counter;
        Counter++;
    }


    public virtual void Load(double cargoWeight)
    {
        if (cargoWeight > MaxWeight || cargoWeight+CargoWeight >MaxWeight)
        {
            throw new OverfillException();
        }
        else
        {
            CargoWeight += cargoWeight;
        }
        
        //throw new NotImplementedException();
    }

    public virtual void  Unload()
    {
        CargoWeight = 0;
        //throw new NotImplementedException();
    }

    public override string ToString()
    {
        return "Kontener nr " + Number
                              + " o numerze seryjnym " + SerialNumber
                              + " aktualny ciężar ładunku " + CargoWeight
                              + " max ciężar kontenera " + MaxWeight;
    }
}