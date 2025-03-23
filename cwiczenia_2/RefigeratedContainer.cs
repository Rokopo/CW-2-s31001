namespace cwiczenia_2;

class RefrigeratedContainer : Container
{
    public string ProductType { get; }
    public double Temperature { get; }

    public RefrigeratedContainer(double maxLoad, double ownWeight, double height, double depth, string product, double temp)
        : base("C", maxLoad, ownWeight, height, depth)
    {
        ProductType = product;
        Temperature = temp;
    }
}