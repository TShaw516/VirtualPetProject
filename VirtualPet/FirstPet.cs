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

        /*public FirstPet()
        {
            
        }*/
        public FirstPet(string petName, string petSpecies)
        {
            PetName = petName;
            PetSpecies = petSpecies;
        }
    }
}
