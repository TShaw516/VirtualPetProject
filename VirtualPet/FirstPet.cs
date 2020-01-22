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

        }
        public FirstPet(string petName, string petSpecies)
        {
            PetName = petName;
            PetSpecies = petSpecies;
            Hunger = 0;
            Boredom = 0;
            Health = 10;
        }

        public void AddPet()
        {

            Console.WriteLine("Welcome to the shelter, the first pet has arrived.");
            Console.WriteLine("What is this pet's name?");
            string nameInput = Console.ReadLine();
            Console.WriteLine("What species is this pet?");
            string speciesInput = Console.ReadLine();
            // FirstPet myPet = new FirstPet(nameInput, speciesInput);
            PetName = nameInput;
            PetSpecies = speciesInput;
            Console.WriteLine("Press any key to return to the Main Menu.");
        }
    }
}

