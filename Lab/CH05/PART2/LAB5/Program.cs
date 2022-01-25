// See https://aka.ms/new-console-template for more information
Console.WriteLine("Please Enter a Test Score");

double testScore = Convert.ToDouble(Console.ReadLine());
int minScore = int.MaxValue;
int maxScore = int.MinValue;
int sumScores = 0;
int numScores = 0;
int averageScore = sumScores / numScores;

for (; ; )
{
    if (testScore > 100 || testScore < 0)
        Console.Write("Enter a Valid Score");
    if (testScore == 999) break;

    else
        if (testScore > int.MinValue)
        Console.WriteLine("Minimum Score is {0}", minScore);

    if (testScore < int.MaxValue)
        Console.WriteLine("Maximum Score is {0}", maxScore);

    Console.WriteLine("The Average Score is {0}", averageScore);
}
