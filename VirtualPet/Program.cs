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
            myPet.ToString();
            VirtualPetShelter myShelter = new VirtualPetShelter();

            do
            {
                myPet.PetMenu();
                userSelection = Console.ReadLine();

                switch (userSelection)
                {
                    case "1":
                        myPet.AddPet();
                        myShelter.AddPetToShelter(myPet);
                        break;

                    case "2":
                        myPet.PetInfo();
                        Console.ReadKey();
                        Console.Clear();
                        break;

                    case "3":
                        myPet.PetStatus();
                        Console.ReadKey();
                        Console.Clear();
                        break;

                    case "4":
                        myPet.FeedPet();
                        Console.ReadKey();
                        Console.Clear();
                        break;

                    case "5":
                        myPet.PlayWithPet();
                        Console.ReadKey();
                        Console.Clear();
                        break;

                    case "6":
                        myPet.TakeToDoctor();
                        Console.ReadKey();
                        Console.Clear();
                        break;
                }
            } while (userSelection != "7");
            

        }

    }
}
