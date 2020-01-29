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
        public void FeedPet()
        {
            Console.WriteLine("You just fed your pet one can of oil.");
            oilLevel += 10;
            Console.WriteLine("Press any key to return to the Main Menu.");
        }

        public void TakeToDoctor()
        {
            Console.WriteLine("You took your pet to the repairshop, yay!");
            performanceLevel += 10;
            Console.WriteLine("Press any key to return to the Main Menu.");
        }
    }
}
