using System;
using System.Collections.Generic;
using System.Text;

namespace VirtualPet
{
    public class VirtualPetShelter
    {
        public List<FirstPet> petsInShelter = new List<FirstPet>();
        

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


        public void SelectPet()
        {
            int petId;
            petId = 1;
            Console.WriteLine("Select the pet you want to interact with!");

            foreach(FirstPet myPet in petsInShelter)
            {
                Console.WriteLine($"{petId}. {myPet.PetName} | {myPet.PetSpecies}");
                petId++;
            }
            ShowAllPetsInfo();
        }

        public void ShowAllPetsStatus()
        {
            for (int i = 0; i < petsInShelter.Count; i++)
            {
                petsInShelter[i].PetStatus();
            }
        }

        public void FeedAllPets()
        {
            for (int i = 0; i < petsInShelter.Count; i++)
            {
                petsInShelter[i].FeedPet();
            }
            

        }

        public void PlayWithAllPets()
        {
            for (int i = 0; i < petsInShelter.Count; i++)
            {
                petsInShelter[i].PlayWithPet();
            }
        }

        public void TakeAllPetsToDoctor()
        {
            for (int i = 0; i < petsInShelter.Count; i++)
            {
                petsInShelter[i].TakeToDoctor();
            }
        }

    }
}
