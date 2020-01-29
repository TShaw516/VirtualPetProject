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


        public void PlayWithPet()
        {
            Console.WriteLine("You just played with your pet!");
            boredom -= 10;
            Console.WriteLine("Press any key to return to the Main Menu.");
        }
    }
}
