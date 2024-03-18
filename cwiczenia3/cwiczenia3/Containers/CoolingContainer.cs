namespace cwiczenia3.Containers;

public class CoolingContainer : Container
{
    PossibleProducts product{ get; set; }
    double temp { get; set; }

    private Dictionary<PossibleProducts, double> productTemp = new Dictionary<PossibleProducts, double>()
    {
        { PossibleProducts.Banana, 13.3 },
        { PossibleProducts.Chocolate, 18 },
        { PossibleProducts.Fish, 2 },
        { PossibleProducts.Meat, -15 },
        { PossibleProducts.Ice_cream, -18 },
        { PossibleProducts.Frozen_pizza, -30 },
        { PossibleProducts.Cheese, 7.2 },
        { PossibleProducts.Sausages, 5 },
        { PossibleProducts.Butter, 20.5 },
        { PossibleProducts.Eggs, 19 }

    };
   
    public CoolingContainer(double cargoWeight, double height, double containerWeight, double depth, double maxWeight, PossibleProducts product, double temp) : base(cargoWeight, height, containerWeight, depth, maxWeight)
    {
        this.product = product;
        this.temp = temp;
        if (temp < productTemp[product])
        {
            throw new Exception();
        }
        Letter = 'C';
        SerialNumber = "KON-"+Letter+"-"+Number;
    }

    public void Load(double cargoWeight, PossibleProducts newProduct)
    {
        base.Load(cargoWeight);
        if (newProduct != product) throw new Exception();
    }

    public override string ToString()
    {
        return base.ToString()+ " typ przewożonego produktu " + product + " w temperaturze " + temp;
    }
}