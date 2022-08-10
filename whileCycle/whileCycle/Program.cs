// See https://aka.ms/new-console-template for more information

bool continueSoftwareExecution = false;
do
{
    Console.WriteLine("Do you wish to keeo the software running? Write 1 if yes, 0 if no");
    int keepgoing = Convert.ToInt32(Console.ReadLine());
    if (1 == keepgoing)
    {
        Console.WriteLine("The software will keep running");
        continueSoftwareExecution = true;
    }
    else if (0 == keepgoing)
    {
        Console.WriteLine("The software will stop");
        continueSoftwareExecution = false;
    }
    else
    {
        Console.WriteLine("Input not valid");
    }
} while (continueSoftwareExecution);
