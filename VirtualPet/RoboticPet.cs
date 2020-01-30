using System;
using System.Collections.Generic;
using System.Text;

namespace VirtualPet
{
    public class RoboticPet : Pet
        {
        //Define Variables
        private int oilLevel;
        private int performanceLevel;

        public int OilLevel
        {
            get { return this.oilLevel; }
            set { this.oilLevel = value; }
        }


        public int PerformanceLevel
        {
            get { return this.performanceLevel; }
            set { this.performanceLevel = value; }
        }

        //Constructor
        public RoboticPet()
        {
            OilLevel = 0;
            PerformanceLevel = 10;
        }

        //methods
        public void AddRoboticPet()
        {
            Console.WriteLine("What is the new robotic pet's name?");
            string nameInput = Console.ReadLine();
            Console.WriteLine("What species is this pet?");
            string speciesInput = Console.ReadLine();
            PetName = nameInput;
            PetSpecies = speciesInput;
        }

        public override void TakeToDoctor()
        {
            Console.WriteLine("You took your pet to the shop, yay!");
            performanceLevel += 10;
            Console.WriteLine("Press any key to return to the Main Menu.");
        }

        public override void FeedPet()
        {
            Console.WriteLine("You just fed your pet one pint of oil.");
            oilLevel += 10;
            Console.WriteLine("Press any key to return to the Main Menu.");
        }

        public override void PetStatus()
        {
            Console.WriteLine($"Pet Name: {PetName} | Oil Level: {oilLevel} | Boredom Level: {Boredom} | Performance Level: {performanceLevel}");
        }
    }
}
