using cwiczenia3.Containers;

namespace cwiczenia3;

public class Ship
{
    public List<Container>? list;
    public double Speed { get; set; }
    public int MaxContainers { get; set; }
    public double MaxContainersWeight { get; set; }

    public Ship( double speed, int maxContainers, double maxContainersWeight)
    {
        list =new List<Container>();
        Speed = speed;
        MaxContainers = maxContainers;
        MaxContainersWeight = maxContainersWeight;
    }

    public void LoadContainer(Container container)
    {
        list.Add(container);
    }
    public void LoadContainer(List<Container> containers)
    {
        foreach(Container con in containers)
        {
            list.Add(con);
        }
    }

    public void UnloadContainer(Container con)
    {
        list.Remove(con);
    }

    public void UnloadShip()
    {
        list.Clear();
    }

    public void SwapContainer(int number, Container? con)
    {
        for (int i = 0; i < list.Count; i++)
        {
            if (list[i].Number == number)
            {
                list[i] = con;
            }
        }
    }

    public void SwapShips(Container con, Ship other)
    {
        list.Remove(con);
        other.list.Add(con);
    }

    public string ListString()
    {
        string result = "";
        foreach (var con in list)
        {
            result += con.ToString() + "\n";
        }

        return result;
    }

    public override string ToString()
    {
        return "Statek o prędkoci " + Speed + " o Max załaduynku " + MaxContainersWeight + " i max ilosci kontenerów " +
               MaxContainers + " przewozi kontenerowce: " +"\n"
               + ListString();
    }
}