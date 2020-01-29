using System;
using System.Collections.Generic;
using System.Text;

namespace VirtualPet
{
    public class VirtualPetShelter
    {
        public List<OrganicPet> petsInShelter = new List<OrganicPet>();
        

        public VirtualPetShelter()
        {
           
        }

        public void AddPetToShelter(OrganicPet pet)
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


        public void ListPetSelection()
        {
            int petId;
            petId = 1;
            Console.WriteLine("Select the pet you want to interact with!");

            foreach(OrganicPet myPet in petsInShelter)
            {
                Console.WriteLine($"{petId}. {myPet.PetName} | {myPet.PetSpecies}");
                petId++;
            }
        }

        public OrganicPet SelectPet()
        {
            int userPetNumber = Convert.ToInt32(Console.ReadLine());
            int petId = (userPetNumber - 1);
            return petsInShelter[petId];
          
            
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
