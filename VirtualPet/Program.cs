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
            string userSelection;
            
            Console.WriteLine("Welcome to the shelter, the first pet has arrived.");
            Console.WriteLine("What is this pet's name?");
            nameInput = Console.ReadLine();
            Console.WriteLine("What species is this pet?");
            speciesInput = Console.ReadLine();
            FirstPet myPet = new FirstPet(nameInput, speciesInput);

            do
            {
                Console.WriteLine("Main Menu:");
                Console.WriteLine("1- View Pet Info");
                Console.WriteLine("2- View Pet Status");
                Console.WriteLine("3- Feed Pet");
                Console.WriteLine("4- Play With Pet");
                Console.WriteLine("5- Take Pet to Doctor");
                Console.WriteLine("6- Quit");
                Console.WriteLine("Select a number to perform an activity!");

                userSelection = Console.ReadLine();

                switch (userSelection)
                {
                    case "1":
                        Console.WriteLine("Your pet's name is: ");
                        Console.WriteLine(myPet.PetName);
                        Console.WriteLine("and this pet is a " + myPet.PetSpecies);
                        Console.WriteLine("Press any key to return to the Main Menu.");
                        Console.ReadKey();
                        Console.Clear();
                        break;

                    case "2":
                        Console.WriteLine("Here is your pet status:");
                        Console.WriteLine("Your pet's hunger level is: " + myPet.Hunger);
                        Console.WriteLine("Your pet's boredom level is: " + myPet.Boredom);
                        Console.WriteLine("Your pet's health level is: " + myPet.Health);
                        Console.ReadKey();
                        Console.Clear();
                        break;

                    case "3":
                        Console.WriteLine("You just fed your pet one bowl of food.");
                        myPet.Hunger = myPet.Hunger - 10;
                        Console.ReadKey();
                        Console.Clear();
                        break;

                    case "4":
                        Console.WriteLine("You just played with your pet!");
                        myPet.Boredom = myPet.Boredom - 10;
                        Console.ReadKey();
                        Console.Clear();
                        break;

                    case "5":
                        Console.WriteLine("You took your pet to the vet, yay!");
                        myPet.Health = myPet.Health + 10;
                        Console.ReadKey();
                        Console.Clear();
                        break;
                }
            } while (userSelection != "6");
            

        }

    }
}
