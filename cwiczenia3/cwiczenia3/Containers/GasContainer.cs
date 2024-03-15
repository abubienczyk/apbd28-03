using cwiczenia3.Interfaces;

namespace cwiczenia3.Containers;

public class GasContainer : Container, IHazardNotifier
{
    public double Pressure { get; set; }

    public GasContainer(double cargoWeight, double height, double containerWeight, double depth, int serialNumber, double maxWeight, double pressure) : base(cargoWeight, height, containerWeight, depth, serialNumber, maxWeight)
    {
        Pressure = pressure;
    }

    public void sendNote()
    {
        throw new NotImplementedException();
    }
}