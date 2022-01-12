// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

Console.WriteLine("Type your distance in miles");

double miles = Convert.ToDouble(Console.ReadLine());

const double KM_PER_MILE = 1.6;

double kilometers = KM_PER_MILE * miles;

Console.WriteLine("{0} miles is equal to {1:N4} kilometers", miles, kilometers);

