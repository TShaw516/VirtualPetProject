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
                myPet.PetMenu();
                userSelection = Console.ReadLine();

                switch (userSelection)
                {
                    case "1":
                        myPet.AddPet();
                        break;

                    case "2":
                        myPet.PetInfo();
                        break;

                    case "3":
                        myPet.PetStatus();
                        break;

                    case "4":
                        myPet.FeedPet();
                        break;

                    case "5":
                        myPet.PlayWithPet();
                        break;

                    case "6":
                        myPet.TakeToDoctor();
                        break;
                }
            } while (userSelection != "7");
            

        }

    }
}
