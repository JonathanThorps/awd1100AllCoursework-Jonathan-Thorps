// See https://aka.ms/new-console-template for more information
Console.WriteLine("How many eggs were laid be each chicken in a month?");

Console.WriteLine("How many eggs did Clare lay?");

double clare = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("How many eggs did Misty lay?");

double misty = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("How many eggs did Iris lay?");

double iris = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("How many eggs did Red lay?");

double red = Convert.ToDouble(Console.ReadLine());

double totalEggs = (clare + misty + iris + red);

const double dozen = 12;

double numDozen = totalEggs / dozen;

double eggs = totalEggs % dozen;

Console.WriteLine("The total of eggs laid is {0}", totalEggs);

Console.WriteLine();

Console.WriteLine("The number of dozens is {0:N0} and the number of eggs is {1:N0}", numDozen, eggs);
