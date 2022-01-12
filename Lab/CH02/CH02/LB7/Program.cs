// See https://aka.ms/new-console-template for more information
Console.WriteLine("Please Enter a Word");

String word = Console.ReadLine();
int StartIndex = 0;
int Length = 1;
string substring = word.Substring(0,1);
string wordMinusFirstChar = word.Substring(1);
Console.WriteLine("{0}{1}ay",wordMinusFirstChar,substring);
