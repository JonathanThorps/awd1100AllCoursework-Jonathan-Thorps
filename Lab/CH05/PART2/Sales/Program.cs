// See https://aka.ms/new-console-template for more information
decimal daniSales = 0m;
decimal edSales = 0m;
decimal frankSales = 0m;
decimal grandTotal = daniSales + edSales + frankSales;


for (; ;)
{
    string d = "Danielle";
    string e = "Edward";
    string f = "Francis";

    Console.WriteLine("Who made the sale?");
    string realtor = Console.ReadLine();
    Console.WriteLine("How much was the sale?");
    decimal sale = Convert.ToDecimal(Console.ReadLine());
    
    if (realtor == "d")
        daniSales += sale + daniSales;

    else if (realtor == "e")
        edSales += sale + edSales;

    else if (realtor == "f")
        frankSales += sale + frankSales;

    else if (realtor == "z")
        if (daniSales == edSales & daniSales == frankSales)
            Console.WriteLine("Everyone is doing a great job!");
        else if (daniSales > edSales & daniSales > frankSales)
            Console.WriteLine("Danielle has the highest sales");
        else if (edSales > daniSales & edSales > frankSales)
            Console.WriteLine("Edward has the highest sales");
        else
            Console.WriteLine("Francis has the highest sales");

    else
        Console.WriteLine("Invalid Initial");
}
