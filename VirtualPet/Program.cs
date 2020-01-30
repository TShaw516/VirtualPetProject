﻿using System;
using VirtualPet;

namespace VirtualPet
{
    class Program
    {
        public static void Main(string[] args)
        {
            string userSelection;
            string userPetSelection;
            OrganicPet myPet = new OrganicPet();
            RoboticPet myRoboticPet = new RoboticPet();
            VirtualPetShelter myShelter = new VirtualPetShelter();
            bool exitGame = false;
      
            do
            {
                myPet.PetMenu();
                userSelection = Console.ReadLine();

                switch (userSelection)
                {
                    case "1":
                        
                        Console.WriteLine("Please Select whether you want to add an organic pet or a robotic pet: ");
                        Console.WriteLine("1- Organic Pet");
                        Console.WriteLine("2- Robotic Pet");
                        userPetSelection = Console.ReadLine();

                        switch (userPetSelection)
                        {  
                            case "1":
                                myPet = new OrganicPet();
                                myPet.AddPet();
                                myShelter.AddPetToShelter(myPet);
                                ScreenClear();
                                break;

                            case "2":
                                myRoboticPet = new RoboticPet();
                                myRoboticPet.AddRoboticPet();
                                myShelter.AddRoboticPetToShelter(myRoboticPet);
                                ScreenClear();
                                break;
                        }
                        break;
                    case "2":
                        switch (userPetSelection)
                        {
                            case "1":
                               
                                int petId;
                                petId = 1;
                                Console.WriteLine("Select the organic pet you want to interact with!");

                                foreach (Pet newPet in organicPetsInShelter)
                                {
                                    Console.WriteLine($"{petId}. {newPet.PetName} | {newPet.PetSpecies}");
                                    petId++;
                                }
                                break;

                            case "2":
                               
                                int roboPetId;
                                roboPetId = 1;
                                Console.WriteLine("Select the robotic pet you want to interact with!");

                                foreach (RoboticPet roboPet in roboPetsInShelter)
                                {
                                    Console.WriteLine($"{roboPetId}. {roboPet.PetName} | {roboPet.PetSpecies}");
                                    roboPetId++;
                                }
                                break;

                        }
                        
                        myShelter.ListPetSelection();
                        myPet = myShelter.SelectPet();
                        Console.WriteLine($"You are now interacting with {myPet.PetName}");
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
            Console.WriteLine("Press any key to return to the Main Menu");
            Console.ReadKey();
            Console.Clear();
        }
    }
}
