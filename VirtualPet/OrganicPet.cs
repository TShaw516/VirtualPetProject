using System;
using System.Collections.Generic;
using System.Text;

namespace VirtualPet
{
    public class OrganicPet : Pet
    {
        //Define Variables
        private int hunger;
        private int health;

        OrganicPet organicPet = new OrganicPet();
        public int Hunger
        {
            get { return this.hunger; }
            set { this.hunger = value; }
        }


        public int Health
        {
            get { return this.health; }
            set { this.health = value; }
        }

        public OrganicPet()
        {

            Hunger = 0;
            Health = 10;
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

        public override void TakeToDoctor()
        {
            Console.WriteLine("You took your pet to the vet, yay!");
            health += 10;
            Console.WriteLine("Press any key to return to the Main Menu.");
        }

        public override void FeedPet()
        {
            Console.WriteLine("You just fed your pet one bowl of food.");
            hunger -= 10;
            Console.WriteLine("Press any key to return to the Main Menu.");
        }

        public override void PetStatus()
        {
            Console.WriteLine($"Pet Name: {PetName} | Hunger Level: {Hunger} | Boredom Level: {Boredom} | Health Level: {Health}");
        }
    }
}

