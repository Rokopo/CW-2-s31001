using cwiczenia_2;

class Program
{
    static void Main()
    {
        CargoShip ship = new CargoShip(500, 10, 20);
        RefrigeratedContainer appleContainer = new RefrigeratedContainer(1000, 500, 250, 600, "Banany", 5);
        GasContainer oilContainer = new GasContainer(2000, 700, 300, 700, 10);
        LiquidContainer orangeContainer = new LiquidContainer(1500, 600, 280, 650, false);
        
        appleContainer.Load(777);
        oilContainer.Load(1337);
        orangeContainer.Load(1200);

        ship.LoadContainer(appleContainer);
        ship.LoadContainer(oilContainer);
        ship.LoadContainer(orangeContainer);

        Console.WriteLine(ship);
        foreach (var c in ship.Containers)
        {
            Console.WriteLine(c);
        }
    }
}