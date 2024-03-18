using cwiczenia3.Interfaces;

namespace cwiczenia3.Containers;

public class GasContainer : Container, IHazardNotifier
{
    public double Pressure { get; set; }

    public GasContainer(double cargoWeight, double height, double containerWeight, double depth, double maxWeight, double pressure) : base(cargoWeight, height, containerWeight, depth, maxWeight)
    {
        Pressure = pressure;
        Letter = 'G';
        SerialNumber = "KON-"+Letter+"-"+Number;
    }

    public override void Unload()
    {
        CargoWeight = CargoWeight * 0.05;
    }
    

    public void sendNote()
    {
        Console.WriteLine("kontener  o nazwie : "+ SerialNumber +" zawiera niebezpieczny ładunek ");
        //throw new NotImplementedException();
    }

    public override string ToString()
    {
        return base.ToString() + " ciśnienie w kontenerze "+Pressure;
    }
}