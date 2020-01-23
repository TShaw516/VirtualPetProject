using System;
using System.Collections.Generic;
using System.Text;

namespace VirtualPet
{
    class VirtualPetShelter
    {
        string num;
        public VirtualPetShelter()
        {
            static void AssignPetID(int num)
            {
                int petID = 1; petID++;
            }
            string userSelection = Console.ReadLine();
            // make pet shelter 
            do
            {
                switch (userSelection)
                {
                    case num:
                        AssignPetID();
                        break;
                }
            }
            while (userSelection != "exit");
        }
    }
}
