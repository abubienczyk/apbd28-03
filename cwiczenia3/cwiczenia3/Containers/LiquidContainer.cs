using cwiczenia3.Exceptions;
using cwiczenia3.Interfaces;

namespace cwiczenia3.Containers;

public class LiquidContainer : Container, IHazardNotifier
{
    public string LiquidType { get; set; }

    public LiquidContainer(double cargoWeight, double height, double containerWeight, double depth, double maxWeight, string liquidType) : base(cargoWeight, height, containerWeight, depth, maxWeight)
    {
        LiquidType = liquidType;
        Letter = 'L';
        SerialNumber = "KON-"+Letter+"-"+Number;
    }

    public override void Load(double cargoWeight)
    {
        if (LiquidType.Equals("niebezpieczny"))
        {
            double half = MaxWeight / 2;
            double toFill = half - CargoWeight;
            if (cargoWeight > toFill) throw new DangerousAcctionException();
            CargoWeight += cargoWeight;
            
        }
        else
        {
            double almostFull = MaxWeight *0.9;
            double toFill = almostFull - CargoWeight;
            if (cargoWeight > toFill) throw new DangerousAcctionException();
            CargoWeight += cargoWeight;
        }
        //base.Load(cargoWeight);
        //throw new NotImplementedException();
    }
    

    public void sendNote()
    {
        Console.WriteLine("kontener  o nazwie : "+ Number +" zawiera niebezpieczny ładunek ");
        //throw new NotImplementedException();
    }

    public override string ToString()
    {
        return base.ToString() + " przewożony ładunke "+LiquidType;
    }
}