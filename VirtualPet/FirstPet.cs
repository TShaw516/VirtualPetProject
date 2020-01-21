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
        public int Health { get; set; }

        public int Boredom { get; set; }
        
        public FirstPet()
        {
            
        }
        public FirstPet(string petName, string petSpecies)
        {
            PetName = petName;
            PetSpecies = petSpecies;
            Hunger = 10;
        }
    }
}
