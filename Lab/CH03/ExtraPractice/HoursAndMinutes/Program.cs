// See https://aka.ms/new-console-template for more information
Console.WriteLine("Enter the number of minutes worked");

double minutesWorked = Convert.ToDouble(Console.ReadLine());

double hour = 60;

double hours = (minutesWorked / hour);

double minutes = (minutesWorked % hour);

Console.WriteLine("{0:N0} hours and {1} minutes", hours, minutes);