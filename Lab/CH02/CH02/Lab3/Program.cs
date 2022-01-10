// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

Console.WriteLine("What is your age?");

int age = Convert.ToInt32(Console.ReadLine());

int daysOld = age * 365;

Console.WriteLine("User is {0} years old, which is {1} days old.", age, daysOld);
