// See https://aka.ms/new-console-template for more information

decimal daniSales = 0m;
decimal edSales = 0m;
decimal frankSales = 0m;
decimal grandTotal = 0m;

for (; ; )
{
    decimal sales = 0m;
    Console.WriteLine("Who made the sale? (d)anielle (e)dward (f)rancis or z to quit");
    string realtor = Console.ReadLine();
    if (realtor == "d" || realtor == "e" || realtor == "f")
    {
        Console.WriteLine("How much was the sale?");
        sales = Convert.ToDecimal(Console.ReadLine());
    }
    switch (realtor)

    {
        case "d":
            daniSales += daniSales + sales;
            grandTotal = grandTotal + daniSales;
            break;
        case "e":
            edSales += edSales + sales;
            grandTotal = grandTotal + edSales;
            break;
        case "f":
            frankSales += frankSales + sales;
            grandTotal = grandTotal + frankSales;
            break;
        case "z":
            Console.WriteLine("Danielle Sales: {0:C}", daniSales);
            Console.WriteLine("Edward Sales: {0:C}", edSales);
            Console.WriteLine("Francis Sales: {0:C}", frankSales);
            Console.WriteLine("Grand total: {0:C}", grandTotal);
            break;
    };

    else
        Console.WriteLine("Invalid Initial");
}
    if (daniSales == edSales && daniSales == frankSales)
        Console.WriteLine("Everyone is tied in sales");
    else if (daniSales > edSales && daniSales > frankSales)
        Console.WriteLine("Danielle has the highest sales");
    else if (edSales > daniSales && edSales > frankSales)
        Console.WriteLine("Edward has the highest sales");
    else
        Console.WriteLine("Francis has the highest sales");
    //if (realtor == "d")
    //daniSales += sales + daniSales;

    //else if (realtor == "e")
    //    edSales =+ sales + edSales;

    //else if (realtor == "f")
    //    frankSales += sales + frankSales;
            
    //else if (realtor == "z")
    //    if (daniSales == edSales & daniSales == frankSales)
    //        Console.WriteLine("Everyone is doing a great job!");
    //    else if (daniSales > edSales & daniSales > frankSales)
    //        Console.WriteLine("Danielle has the highest sales");
    //    else if (edSales > daniSales & edSales > frankSales)
    //        Console.WriteLine("Edward has the highest sales");
    //    else
    //        Console.WriteLine("Francis has the highest sales");
    
    //else
    //    Console.WriteLine("Invalid Initial");
