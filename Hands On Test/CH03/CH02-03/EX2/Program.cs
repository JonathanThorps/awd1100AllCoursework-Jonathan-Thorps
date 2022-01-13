// See https://aka.ms/new-console-template for more information
Console.WriteLine("Please enter three numbers");

Console.WriteLine("Enter the first number");

double firstNum = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("Enter the second number");

double secondNum = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("Enter the third number");

double thirdNum = Convert.ToDouble(Console.ReadLine());

double average = (firstNum + secondNum + thirdNum) / 3;

Console.WriteLine("The average of the three numbers is {0}", average);

