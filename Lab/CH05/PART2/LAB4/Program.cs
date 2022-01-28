// See https://aka.ms/new-console-template for more information
Console.WriteLine("How many rows should the table have");
int numRows = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("How many columns should the table have");
int numColumns = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("    | 1 | 2 | 3 | 4 | 5 | 6 | 7 | 8 | 9 | 10 |");
Console.WriteLine("____________________________________________");

for (int i = 1; i <= numRows; i++)
{
    Console.WriteLine("| {0} |", i);

    for (int j = 1; j <= numColumns; j++)
        Console.WriteLine("| {0} |", j * i++);

    i++;

    if (i > numColumns)
        break;

}