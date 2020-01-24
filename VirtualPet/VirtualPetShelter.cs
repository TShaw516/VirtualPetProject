﻿using System;
using System.Collections.Generic;
using System.Text;

namespace VirtualPet
{
    class VirtualPetShelter
    {
        List<FirstPet> petsInShelter = new List<FirstPet>();
        

        public VirtualPetShelter()
        {
           
        }

        public void AddPetToShelter(FirstPet pet)
        {
            petsInShelter.Add(pet);

        }    

        public void ShowAllPetsInfo()
        {
            for (int i = 0; i < petsInShelter.Count; i++)
            {
                petsInShelter[i].PetInfo();
            }
        }
    }
}
