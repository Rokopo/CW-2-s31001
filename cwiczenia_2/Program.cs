using cwiczenia_2;

class Program
{
    static void Main()
    {
        CargoShip ship1 = new CargoShip(500, 10, 20);
        CargoShip ship2 = new CargoShip(700, 15, 25);

        RefrigeratedContainer bananaContainer = new RefrigeratedContainer(1000, 500, 250, 600, "Banany", 5);
        GasContainer heliumContainer = new GasContainer(2000, 700, 300, 700, 10);
        LiquidContainer milkContainer = new LiquidContainer(1500, 600, 280, 650, false);

        bananaContainer.Load(900);
        heliumContainer.Load(1900);
        milkContainer.Load(1200);

        ship1.LoadContainer(bananaContainer);
        ship1.LoadContainer(heliumContainer);
        ship1.LoadContainer(milkContainer);

        Console.WriteLine(ship1);
        foreach (var c in ship1.Containers)
        {
            Console.WriteLine(c);
        }

        Console.WriteLine("\nRozładowanie kontenera.");
        bananaContainer.Unload();
        Console.WriteLine(bananaContainer);

        Console.WriteLine("\nPrzeniesienie kontenera na inny statek.");
        ship1.UnloadContainer(milkContainer);
        ship2.LoadContainer(milkContainer);
        Console.WriteLine(ship2);

        Console.WriteLine("\nZastąpienie kontenera.");
        ship1.UnloadContainer(heliumContainer);
        ship1.LoadContainer(new GasContainer(2500, 800, 320, 750, 15));
        Console.WriteLine(ship1);
    }
}