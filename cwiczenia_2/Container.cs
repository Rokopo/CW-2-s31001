namespace cwiczenia_2;

abstract class Container
{
    private static int counter = 1;
    public string SerialNumber { get; }
    public double LoadMass { get; set; }
    public double MaxLoadCapacity { get; }
    public double OwnWeight { get; }
    public double Height { get; }
    public double Depth { get; }

    protected Container(string type, double maxLoad, double ownWeight, double height, double depth)
    {
        SerialNumber = $"KON-{type}-{counter++}";
        MaxLoadCapacity = maxLoad;
        OwnWeight = ownWeight;
        Height = height;
        Depth = depth;
    }

    public virtual void Load(double mass)
    {
        if (mass > MaxLoadCapacity)
            throw new Exception("OverfillException: Przekroczono maksymalną ładowność!");
        LoadMass = mass;
    }

    public virtual void Unload()
    {
        LoadMass = 0;
    }

    public override string ToString() => $"[{SerialNumber}] Masa ładunku: {LoadMass}/{MaxLoadCapacity} kg";
}    
