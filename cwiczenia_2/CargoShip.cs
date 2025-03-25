namespace cwiczenia_2;

public class CargoShip
{
    public List<Container> Containers { get; } = new List<Container>();
    public double MaxWeight { get; }
    public int MaxContainers { get; }
    public double MaxSpeed { get; }

    public CargoShip(double maxWeight, int maxContainers, double maxSpeed)
    {
        MaxWeight = maxWeight;
        MaxContainers = maxContainers;
        MaxSpeed = maxSpeed;
    }

    public void LoadContainer(Container container)
    {
        if (Containers.Count >= MaxContainers)
            throw new Exception("Statek osiągnął maksymalną liczbę kontenerów!");
        if (GetTotalWeight() + container.OwnWeight + container.LoadMass > MaxWeight * 1000)
            throw new Exception("Przekroczono maksymalną wagę ładunku!");
        Containers.Add(container);
    }

    public void UnloadContainer(Container container)
    {
        Containers.Remove(container);
    }

    public Container FindContainerBySerial(string serialNumber)
    {
        return Containers.Find(c => c.SerialNumber == serialNumber);
    }

    public double GetTotalWeight()
    {
        double totalWeight = 0;
        foreach (var container in Containers)
        {
            totalWeight += container.OwnWeight + container.LoadMass;
        }
        return totalWeight;
    }

    public override string ToString()
    {
        return $"Kontenerowiec - Max waga: {MaxWeight}t, Max kontenery: {MaxContainers}, Prędkość: {MaxSpeed} węzłów, Aktualna ilość kontenerów: {Containers.Count}";
    }
}