using System;
using VirtualPet;

namespace VirtualPet
{
    class Program
    {
        public static void Main(string[] args)
        {
            string userSelection;
            FirstPet myPet = new FirstPet();

            do
            {
                Console.WriteLine("Main Menu:");
                Console.WriteLine("1- Add a Pet to the Shelter");
                Console.WriteLine("2- View Pet Info");
                Console.WriteLine("3- View Pet Status");
                Console.WriteLine("4- Feed Pet");
                Console.WriteLine("5- Play With Pet");
                Console.WriteLine("6- Take Pet to Doctor");
                Console.WriteLine("7- Quit");
                Console.WriteLine("Select a number to perform an activity!");

                userSelection = Console.ReadLine();

                switch (userSelection)
                {
                    case "1":
                        myPet.AddPet();
                        break;

                    case "2":
                        Console.WriteLine("Your pet's name is: ");
                        Console.WriteLine(myPet.PetName);
                        Console.WriteLine("and this pet is a " + myPet.PetSpecies);
                        Console.WriteLine("Press any key to return to the Main Menu.");
                        Console.ReadKey();
                        Console.Clear();
                        break;

                    case "3":
                        Console.WriteLine("Here is your pet status:");
                        Console.WriteLine("Your pet's hunger level is: " + myPet.Hunger);
                        Console.WriteLine("Your pet's boredom level is: " + myPet.Boredom);
                        Console.WriteLine("Your pet's health level is: " + myPet.Health);
                        Console.WriteLine("Press any key to return to the Main Menu.");
                        Console.ReadKey();
                        Console.Clear();
                        break;

                    case "4":
                        Console.WriteLine("You just fed your pet one bowl of food.");
                        myPet.Hunger = myPet.Hunger - 10;
                        Console.WriteLine("Press any key to return to the Main Menu.");
                        Console.ReadKey();
                        Console.Clear();
                        break;

                    case "5":
                        Console.WriteLine("You just played with your pet!");
                        myPet.Boredom = myPet.Boredom - 10;
                        Console.WriteLine("Press any key to return to the Main Menu.");
                        Console.ReadKey();
                        Console.Clear();
                        break;

                    case "6":
                        Console.WriteLine("You took your pet to the vet, yay!");
                        myPet.Health = myPet.Health + 10;
                        Console.WriteLine("Press any key to return to the Main Menu.");
                        Console.ReadKey();
                        Console.Clear();
                        break;
                }
            } while (userSelection != "7");
            

        }

    }
}
