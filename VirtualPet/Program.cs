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
                        myShelter.SelectPet();
                        ScreenClear();
                        break;

                    case "3":
                        myShelter.ShowAllPetsInfo();
                        ScreenClear();
                        break;

                    case "4":
                        myShelter.ShowAllPetsStatus();
                        ScreenClear();
                        break;

                    case "5":
                        Console.WriteLine("Please select a number from the following: ");
                        Console.WriteLine("1- Feed single pet");
                        Console.WriteLine("2- Feed all pets in shelter");
                        userSelection = Console.ReadLine();
                        ScreenClear();

                        switch (userSelection)
                        {
                            case "1":
                                myPet.FeedPet();
                                break;

                            case "2":
                                myShelter.FeedAllPets();
                                break;
                        }
                        break;

                    case "6":
                        Console.WriteLine("Please select a number from the following: ");
                        Console.WriteLine("1- Play with a single pet");
                        Console.WriteLine("2- Play with all pets in shelter");
                        userSelection = Console.ReadLine();
                        ScreenClear();

                        switch (userSelection)
                        {
                            case "1":
                                myPet.PlayWithPet();
                                break;

                            case "2":
                                myShelter.PlayWithAllPets();
                                break;
                        }
                        break;

                    case "7":
                        Console.WriteLine("Please select a number from the following: ");
                        Console.WriteLine("1- Take one pet to the doctor");
                        Console.WriteLine("2- Take all pets to the doctor");
                        userSelection = Console.ReadLine();
                        ScreenClear();

                        switch (userSelection)
                        {
                            case "1":
                                myPet.TakeToDoctor();
                                break;

                            case "2":
                                myShelter.TakeAllPetsToDoctor();
                                break;
                        }
                        break;

                    case "8":
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
