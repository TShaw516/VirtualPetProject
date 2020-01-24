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
            VirtualPetShelter myShelter = new VirtualPetShelter();

            

            do
            {
                myPet.PetMenu();
                userSelection = Console.ReadLine();

                switch (userSelection)
                {
                    case "1":
                        myPet = new FirstPet();
                        myPet.AddPet();
                        myShelter.AddPetToShelter(myPet);
                        break;

                    case "2":
                        myShelter.ShowAllPetsInfo();
                        ScreenClear();
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

        static void ScreenClear()
        {
            Console.WriteLine("Press any key to return to the Main Menu!");
            Console.ReadKey();
            Console.Clear();
        }
    }
}
