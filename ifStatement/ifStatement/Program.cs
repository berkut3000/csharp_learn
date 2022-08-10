// See https://aka.ms/new-console-template for more information

int anyValue = 14;
string message = "";

if (anyValue == 7)
{
    message = "Oh, my GOd! AnyValue is 7";
}
else if(anyValue == 14)
{
    message = "OMG, it's a double miracle the value is 14";
}
else
{
    message = "puff, the value wasn't 7";
}

Console.WriteLine($"The answer is> {message}");
