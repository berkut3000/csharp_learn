// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

Console.WriteLine("ingresa el producto deseado: ");
string caseSwitch = Console.ReadLine();

switch(caseSwitch)
{
    case "delaware punch":
        Console.WriteLine("delware punch - $20.00");
        break;
    case "nuka cola":
        Console.WriteLine("nuka cola - $18.00");
        break;
    case "tepehuani":
        Console.WriteLine("tepehuani - $18.00");
        break;
    default:
        Console.WriteLine("ERROR: La cagaste, como en tu vida.");
        break;
}
