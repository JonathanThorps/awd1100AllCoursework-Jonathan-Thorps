// See https://aka.ms/new-console-template for more information
Console.WriteLine("Please Enter your name");

string name = Console.ReadLine();

Console.WriteLine("Enter your street address");

string address = Console.ReadLine();

Console.WriteLine("Enter your city");

string city = Console.ReadLine();

Console.WriteLine("Enter your state");

string state = Console.ReadLine();

Console.WriteLine("Enter your zip code");

string zipCode = Console.ReadLine();

Console.WriteLine("How many t-shirts did you want to order?");

double tshirtOrder = Convert.ToDouble(Console.ReadLine());

const double tshirtPrice = 14.99;

const double salesTaxRate = .08;

double total = tshirtOrder * tshirtPrice;

double salesTax = total * salesTaxRate;

double totalCost = salesTax + total;

Console.WriteLine();

Console.WriteLine("Name: {0}", name);
Console.WriteLine("Address: {0}", address);
Console.WriteLine("City: {0}", city);
Console.WriteLine("State: {0}", state);
Console.WriteLine("Zip Code: {0}", zipCode);

Console.WriteLine();

Console.WriteLine("You are purchasing {0} t-shirts at $14.99 each.", tshirtOrder);

Console.WriteLine();

Console.WriteLine("Receipt for:");

Console.WriteLine();

Console.WriteLine("Total: {0:N2}", total);
Console.WriteLine("Tax: {0:N2}", salesTax);
Console.WriteLine("---------------");
Console.WriteLine("Amount Due: {0:N2}", totalCost);
