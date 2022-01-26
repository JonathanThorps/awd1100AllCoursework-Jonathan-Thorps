// See https://aka.ms/new-console-template for more information

decimal daniSales = 0m;
decimal edSales = 0m;
decimal frankSales = 0m;



for (; ; )
{
    Console.WriteLine("Who made the sale?");
string realtor = Console.ReadLine();
Console.WriteLine("How much was the sale?");
decimal sales = Convert.ToDecimal(Console.ReadLine());

    switch (realtor)

{
    case "d":
        daniSales = daniSales + sales;
        break;
    case "e":
        edSales = edSales + sales;
        break;
    case "f":
        frankSales = frankSales + sales;
        break;
};
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
}
