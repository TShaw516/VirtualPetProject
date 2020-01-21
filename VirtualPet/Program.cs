using System;
using VirtualPet;

namespace VirtualPet
{
    class Program
    {
        static void Main(string[] args)
        {
            string nameInput;
            string speciesInput;
            
            Console.WriteLine("Welcome to the shelter. <insert main menu text here when ready>");
            Console.WriteLine("Enter your pet's name here:");
            nameInput = Console.ReadLine();
            Console.WriteLine("Enter your pet's species here:");
            speciesInput = Console.ReadLine();
            FirstPet myPet = new FirstPet(nameInput, speciesInput);
        }

    }
}
