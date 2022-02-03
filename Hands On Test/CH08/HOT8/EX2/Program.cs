// See https://aka.ms/new-console-template for more information
Console.WriteLine("Enter price of shopping cart items or press [0] to quit");

for (int i = 1; i < 10 ; i++)
{
    decimal subtotal = 0;
    const decimal tax = 0.08m;
    int numItems = 0;
    decimal itemPrice = Convert.ToDecimal(Console.ReadLine());

    if (itemPrice > 0)
    {
        subtotal = subtotal + itemPrice;
        numItems += i;
    }

    if(itemPrice == 0)
    {
        Console.WriteLine("Items Purchased {0}", numItems);
        Console.WriteLine("Average Price {0:C}", subtotal / numItems);
        Console.WriteLine("SubTotal: {0:C}", subtotal);
        Console.WriteLine("Tax: {0:C}", tax * subtotal);
        Console.WriteLine("Total: {0:C}", (subtotal * tax) + subtotal);
        break;
    }
    
    else if (itemPrice < 0)
    {
        Console.WriteLine("Invalid Price!");
    }
}





