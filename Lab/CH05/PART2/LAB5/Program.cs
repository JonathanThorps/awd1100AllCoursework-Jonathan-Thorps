// See https://aka.ms/new-console-template for more information
Console.WriteLine("Please Enter a Test Score");
Console.ReadLine();

double testScore = 0;
int numScores = 0;
int minScore = int.MaxValue;
int maxScore = int.MinValue;

for (; ; )
{
    if (testScore > 100 || testScore < 0)
        Console.Write("Enter a Valid Score");
    if (testScore == 999) break;
}
