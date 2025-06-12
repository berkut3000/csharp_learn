// See https://aka.ms/new-console-template for more information
Console.WriteLine("Creacion de Objetos");
Console.WriteLine();

var sale = new Sale(15);
var message = sale.GetInfo();
Console.WriteLine(message);


class Sale
{
    public decimal Total { get; set; }
    private decimal _some;

    public Sale(decimal total)
    {
        Total = total;
    }

    public string GetInfo()
    {
        return "El total es " + Total;
    }
}