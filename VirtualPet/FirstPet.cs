using System;
using System.Collections.Generic;
using System.Text;

namespace VirtualPet
{
    public class FirstPet
    {
        //Define Variables
        private string petName;
        private string petSpecies;
        private int hunger;
        private int boredom;
        private int health;

        public string PetName
        {
            get { return this.petName; }
            set { this.petName = value; }
        }

        public string PetSpecies
        {
            get { return this.petSpecies; }
            set { this.petSpecies = value; }
        }

        public int Hunger
        {
            get { return this.hunger; }
            set { this.hunger = value; }
        }

        public int Boredom
        {
            get { return this.boredom; }
            set { this.boredom = value; }
        }

        public int Health
        {
            get { return this.health; }
            set { this.health = value; }
        }

        public FirstPet()
        {
            PetName = petName;
            PetSpecies = petSpecies;
            Hunger = 0;
            Boredom = 0;
            Health = 10;
        }

        public void PetMenu()
        {
            Console.WriteLine("Welcome to the Virtual Pet Shelter! What would you like to do?");
            Console.WriteLine();
            Console.WriteLine("Main Menu:");
            Console.WriteLine("1- Add a Pet to the Shelter");
            Console.WriteLine("2- Change Currently Selected Pet");
            Console.WriteLine("3- View Pet Info");
            Console.WriteLine("4- View Pet Status");
            Console.WriteLine("5- Feed Pet");
            Console.WriteLine("6- Play With Pet");
            Console.WriteLine("7- Take Pet to Doctor");
            Console.WriteLine("8- Quit");
            Console.WriteLine("Select a number to perform an activity!");
        }

        public void AddPet()
        {
            Console.WriteLine("What is the new pet's name?");
            string nameInput = Console.ReadLine();
            Console.WriteLine("What species is this pet?");
            string speciesInput = Console.ReadLine();
            PetName = nameInput;
            PetSpecies = speciesInput;
        }

        public void PetInfo()
        {
            Console.WriteLine($"Name: {PetName} | Species: {PetSpecies}");
        }

        public void ShelterContents()
        {
            FirstPet petsInShelter = new FirstPet();
        }

        public void PetStatus()
        {
            Console.WriteLine($"Pet Name: {PetName} | Hunger Level: {Hunger} | Boredom Level: {Boredom} | Health Level: {Health}");
        }

        public void FeedPet()
        {
            Console.WriteLine("You just fed your pet one bowl of food.");
            hunger -= 10;
            Console.WriteLine("Press any key to return to the Main Menu.");
        }

        public void PlayWithPet()
        {
            Console.WriteLine("You just played with your pet!");
            boredom -= 10;
            Console.WriteLine("Press any key to return to the Main Menu.");
        }

        public void TakeToDoctor()
        {
            Console.WriteLine("You took your pet to the vet, yay!");
            health += 10;
            Console.WriteLine("Press any key to return to the Main Menu.");
        }
    }
}

