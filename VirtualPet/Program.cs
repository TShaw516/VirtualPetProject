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
            bool exitGame = false;
        
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
                        ScreenClear();
                        break;

                    case "2":
                        myShelter.ShowAllPetsInfo();
                        ScreenClear();
                        break;

                    case "3":
                        myShelter.ShowAllPetsStatus();
                        ScreenClear();
                        break;

                    case "4":
                        myShelter.FeedAllPets();
                        ScreenClear();
                        break;

                    case "5":
                        myShelter.PlayWithAllPets();
                        ScreenClear();
                        break;

                    case "6":
                        myShelter.TakeAllPetsToDoctor();
                        ScreenClear();
                        break;

                    case "7":
                        exitGame = true;
                        break;
                }
                    

             } while (exitGame == false);
        }

        static void ScreenClear()
        {
            Console.WriteLine("Press any key to return to the Main Menu!");
            Console.ReadKey();
            Console.Clear();
        }
    }
}
