// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

string[] userNames = new string[10] {"", "","","","","","","","",""};
int arrayCurrentIndex = 0;
bool usertType = false;
while(arrayCurrentIndex < 4)
{
    Console.WriteLine("Current reserved guests : {0}", arrayCurrentIndex);
/*    if(arrayCurrentIndex == 5)
    {
        Console.WriteLine("The restaurant is full! Try again next year.");
        Environment.Exit(0);
    }*/
    Console.WriteLine("are you a registered user? Write true, or write false to register");
    usertType = Convert.ToBoolean(Console.ReadLine());
    if(usertType)
    {
        Console.WriteLine("Hello, you are a registered user, please enter your username");
        string UserToSearch = Console.ReadLine();
        Console.WriteLine("The user you are looking for is {0}", UserToSearch);
        int index = Array.IndexOf(userNames, UserToSearch);
        if(index == -1)
        {
            Console.WriteLine("User not found, try again or register");
        }
        else
        {
            Console.WriteLine("Welcome, {0}, it is a pleasure to give you food", userNames[index]);
        }

    }else if (!usertType)
    {
        Console.WriteLine("Please input your username");
        userNames[arrayCurrentIndex] = Console.ReadLine();
        Console.WriteLine("Your user has been saved succesfully");
        arrayCurrentIndex++;
    }
}
Console.WriteLine("The restaurant is full! Try again next year.");
int i = 1;
foreach(string name in userNames)
{
    Console.WriteLine("Usernumber: {0}: Username: {1}", i, name );
    i++;
}
Environment.Exit(0);
