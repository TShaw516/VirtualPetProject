using System;
using VirtualPet;

namespace VirtualPet
{
    class Program
    {
        public static void Main(string[] args)
        {
            string nameInput;
            string speciesInput;
            
            Console.WriteLine("Welcome to the shelter. <insert main menu text here when ready>");
            Console.WriteLine("Enter your pet's name here:");
            nameInput = Console.ReadLine();
            Console.WriteLine("Enter your pet's species here:");
            speciesInput = Console.ReadLine();
            FirstPet myPet = new FirstPet(nameInput, speciesInput);

            Console.WriteLine("Main Menu:");
            Console.WriteLine("1- View Pet info");
            Console.WriteLine("2- View Pet status");
            Console.WriteLine("3- Feed Pet");
            Console.WriteLine("4- Play With Pet");
            Console.WriteLine("5- Take Pet to Doctor");
            Console.WriteLine("6- Quit");
            Console.WriteLine("Press a number to choose a task.");
        }

    }
}
