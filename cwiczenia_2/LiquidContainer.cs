namespace cwiczenia_2;

class LiquidContainer : Container, IHazardNotifier
{
    private bool isHazardous;
    public LiquidContainer(double maxLoad, double ownWeight, double height, double depth, bool hazardous)
        : base("L", maxLoad, ownWeight, height, depth)
    {
        isHazardous = hazardous;
    }

    public override void Load(double mass)
    {
        double limit = isHazardous ? MaxLoadCapacity * 0.5 : MaxLoadCapacity * 0.9;
        if (mass > limit)
        {
            NotifyHazard("Próba załadunku ponad dozwoloną pojemność dla niebezpiecznego ładunku.");
            throw new Exception("OverfillException");
        }
        base.Load(mass);
    }

    public void NotifyHazard(string message)
    {
        Console.WriteLine($"[UWAGA] {SerialNumber}: {message}");
    }
}