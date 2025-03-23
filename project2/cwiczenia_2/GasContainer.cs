namespace cwiczenia_2;

class GasContainer : Container, IHazardNotifier
{
    public double Pressure { get; }

    public GasContainer(double maxLoad, double ownWeight, double height, double depth, double pressure)
        : base("G", maxLoad, ownWeight, height, depth)
    {
        Pressure = pressure;
    }

    public override void Unload()
    {
        LoadMass *= 0.05;
    }

    public void NotifyHazard(string message)
    {
        Console.WriteLine($"[UWAGA] {SerialNumber}: {message}");
    }
}