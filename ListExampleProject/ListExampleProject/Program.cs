// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

List<string> tacoShoppingList = new List<string>();
tacoShoppingList.Add("Cinco Tacos de Suadero");
tacoShoppingList.Add("Cuatro tacos de tripa");
tacoShoppingList.Add("Cinco tacos de pastor");
tacoShoppingList.Add("4 coca colas");

for (int i = 0; i < tacoShoppingList.Count; i++)
{
    Console.WriteLine(tacoShoppingList[i]);
}
Console.WriteLine("Eliminando elementos de la lista");
tacoShoppingList.RemoveRange(1, tacoShoppingList.Count - 2);

for (int i = 0; i < tacoShoppingList.Count; i++)
{
    Console.WriteLine(tacoShoppingList[i]);
}

Console.WriteLine("Eliminando elementos de la lista");
tacoShoppingList.RemoveAt(1);
for (int i = 0; i < tacoShoppingList.Count; i++)
{
    Console.WriteLine(tacoShoppingList[i]);
}