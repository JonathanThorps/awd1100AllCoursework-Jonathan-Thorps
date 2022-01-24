// See https://aka.ms/new-console-template for more information
Console.WriteLine("Enter purchase price");

decimal price = Convert.ToDecimal(Console.ReadLine());

if (price <= 5000)

    Console.WriteLine("Approved");

else

    Console.WriteLine("Price exceeds credit limit");

