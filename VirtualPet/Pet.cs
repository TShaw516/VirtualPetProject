using System;
using System.Collections.Generic;
using System.Text;

namespace VirtualPet
{
    public class Pet
    {
        //Properties
        private string petName;
        private string petSpecies;
        private int boredom;
        
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

        public int Boredom
        {
            get { return this.boredom; }
            set { this.boredom = value; }
        }

        //Constructor
        public Pet()
        {
            PetName = petName;
            PetSpecies = petSpecies;
            Boredom = 0;
        }

        //Methods
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


        public void PlayWithPet()
        {
            Console.WriteLine("You just played with your pet!");
            boredom -= 10;
            Console.WriteLine("Press any key to return to the Main Menu.");
        }

        public void PetInfo()
        {
            Console.WriteLine($"Name: {PetName} | Species: {PetSpecies}");
        }

        public virtual void FeedPet()
        {
        }

        public virtual void TakeToDoctor()
        {
        }

        public virtual void PetStatus()
        { 
        }

    }
}
