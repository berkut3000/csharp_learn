// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

string[] coffeeTypes = new string[] {"Expresso", "Largo", "Filtrado", "latte" };
float[] coffeePrices = new float[] {1.2f, 1.5f, 5.0f, 5.5f };

for (int i= 0; i< 4; i++)
{
    Console.WriteLine(coffeeTypes[i] + " Coffee $" + coffeePrices[i]);
}
