// See https://aka.ms/new-console-template for more information
Console.WriteLine("Good morning!");

Console.WriteLine("Enter first employee's name");

string employee1 = Console.ReadLine();

Console.WriteLine("Enter first employee's salary");

double salary1 = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("Enter second employee's name");

string employee2 = Console.ReadLine();

Console.WriteLine("Enter second employee's salary");

double salary2 = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("Enter third employee's name");

string employee3 = Console.ReadLine();

Console.WriteLine("Enter third employee's salary");

double salary3 = Convert.ToDouble(Console.ReadLine());

const double PERCENT_RAISE = 0.04;

double empSalary1 = (salary1 * PERCENT_RAISE) + salary1;

double empSalary2 = (salary2 * PERCENT_RAISE) + salary2;

double empSalary3 = (salary3 * PERCENT_RAISE) + salary3;

double empSalary1Yr2 = (empSalary1 * PERCENT_RAISE) + empSalary1;

double empSalary2Yr2 = (empSalary2 * PERCENT_RAISE) + empSalary2;

double empSalary3Yr2 = (empSalary3 * PERCENT_RAISE) + empSalary3;

Console.WriteLine("Year     {0}      {1}      {2}", employee1,employee2,employee3);
Console.WriteLine("2018     {0}      {1}      {2}", salary1, salary2, salary3);
Console.WriteLine("2019     {0}      {1}      {2}", empSalary1, empSalary2, empSalary3);
Console.WriteLine("2020     {0}      {1}      {2}", empSalary1Yr2,empSalary2Yr2,empSalary3Yr2);

