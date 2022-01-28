// See https://aka.ms/new-console-template for more information
decimal daniSales = 0m;
decimal edSales = 0m;
decimal frankSales = 0m;
decimal grandTotal = 0m;


for (; ;)
{
    string d = "Danielle";
    string e = "Edward";
    string f = "Francis";
    decimal sale = 0m;
    Console.WriteLine("Who made the sale? ((d)anielle, (e)dward, (f)rank, or z to quit)");
    string realtor = Console.ReadLine();
    if(realtor == "d" || realtor == "e" || realtor == "f")
    { 
        Console.WriteLine("How much was the sale?");
        sale = Convert.ToDecimal(Console.ReadLine());
    }

    if (realtor == "d")
    {
        daniSales += sale + daniSales;
        grandTotal = grandTotal + daniSales;
    }
    else if (realtor == "e")
    {
        edSales += sale + edSales;
        grandTotal = grandTotal + edSales;
    }

    else if (realtor == "f")
    {
        frankSales += sale + frankSales;
        grandTotal = grandTotal + frankSales;
    }
    else if (realtor == "z")
    {
        Console.WriteLine("Danielle's Sales:{0:C}", daniSales);
        Console.WriteLine("Edward's Sales:{0:C}", edSales);
        Console.WriteLine("Francis' Sales:{0:C}", frankSales);
        Console.WriteLine("The total sales are {0:C}", grandTotal);
        if (daniSales == edSales & daniSales == frankSales)
            Console.WriteLine("Everyone is doing a great job!");
        else if (daniSales > edSales & daniSales > frankSales)
            Console.WriteLine("Danielle has the highest sales");
        else if (edSales > daniSales & edSales > frankSales)
            Console.WriteLine("Edward has the highest sales");
        else
            Console.WriteLine("Francis has the highest sales");
        break;
    }
    else
        Console.WriteLine("Invalid Initial");
}
