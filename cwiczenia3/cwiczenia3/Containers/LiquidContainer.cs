using cwiczenia3.Interfaces;

namespace cwiczenia3.Containers;

public class LiquidContainer : Container, IHazardNotifier
{
    public string LiquidType { get; set; }

    public LiquidContainer(double cargoWeight, double height, double containerWeight, double depth, int serialNumber, double maxWeight, string liquidType) : base(cargoWeight, height, containerWeight, depth, serialNumber, maxWeight)
    {
        LiquidType = liquidType;
    }

    public override void Load(double cargoWeight)
    {
        base.Load(cargoWeight);
        if (LiquidType.Equals("paliwo"))
        {
           // base.CargoWeight;
        }
        throw new NotImplementedException();
    }

    public void sendNote()
    {
        throw new NotImplementedException();
    }
}