// See https://aka.ms/new-console-template for more information
Console.WriteLine("Enter student test scores");

Console.WriteLine("Enter first test score");

double score1 = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("Enter second test score");

double score2 = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("Enter third test score");

double score3 = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("Enter fourth test score");

double score4 = Convert.ToDouble(Console.ReadLine());

double testAverage = (score1 + score2 + score3 + score4) / 4;

Console.WriteLine("The student's average is {0}", testAverage);
