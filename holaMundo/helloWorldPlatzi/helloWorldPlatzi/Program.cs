using System;

namespace helloWorldPlatzi
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello Platzi!");
            int height = 170;
            int age = 20;
            string name = "Antonio Aguilar";
            string information = "The requested information is: User Name: " + name + "\r\nUser age: " + age + "\r\nUser Height: " + height;
            Console.WriteLine(information); 
        }
    }
}
