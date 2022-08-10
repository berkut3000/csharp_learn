// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");
int num = 4;
int productaA = Square(num);
Console.WriteLine(productaA);
integerAddition(3, 5);
Console.WriteLine(integerMultiplication(4.5f, 2f));
Console.WriteLine(integerDivision(9f, 2f));

static int Square(int i)
{
    return i * i;
}

void integerAddition(int a, int b)
{
    int addition = a + b;
    Console.WriteLine(addition);
}

float integerMultiplication(float a, float b)
{
    return a * b;
}

float integerDivision(float a, float b)
{
    return a / b; ;
}
