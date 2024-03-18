// See https://aka.ms/new-console-template for more information

using cwiczenia3;
using cwiczenia3.Containers;

LiquidContainer con2 = new LiquidContainer(290.5, 3, 2, 5, 350, "niebezpieczny");
con2.Unload();
con2.Load(80);
Console.WriteLine(con2.CargoWeight);

Console.WriteLine(con2);

GasContainer con1 = new GasContainer(100, 5, 50, 3, 273, 1081);
con1.Unload();
Console.WriteLine(con1);

GasContainer con3 = new GasContainer(190, 5, 50, 3, 204, 997);
List<Container> lista = new List<Container>() { con2, con3 };


Ship statek1 = new Ship(160, 5, 860 );
statek1.LoadContainer(con1);
statek1.LoadContainer(lista);
Console.WriteLine(statek1);

Ship statek2 = new Ship(201, 3, 777);
statek1.SwapShips(con2, statek2);

