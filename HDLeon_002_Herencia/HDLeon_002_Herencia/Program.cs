// See https://aka.ms/new-console-template for more information
Console.WriteLine("Creacion de Objetos");
Console.WriteLine();

var sale = new SaleWithTax(15, 1.16m);
var message = sale.GetInfo();
Console.WriteLine(message);

message = sale.GetInfo("Hola");
Console.WriteLine(message);

message = sale.GetInfo(1);
Console.WriteLine(message);



class SaleWithTax : Sale
{

    public decimal Tax { get; set; }

    public SaleWithTax(decimal total, decimal tax) : base(total)
    {
        Tax = tax;
    }

    public override string GetInfo()
    {
        return "El total es " + Total + " Impuesto es: " + Tax;
    }

    public string GetInfo(string message)
    {
        return message;
    }

    public string GetInfo(int a)
    {
        return a.ToString();
    }
 }


class Sale
{
    public decimal Total { get; set; }
    private decimal _some;

    public Sale(decimal total)
    {
        Total = total;
    }

    public virtual string GetInfo()
    {
        return "El total es " + Total;
    }
}