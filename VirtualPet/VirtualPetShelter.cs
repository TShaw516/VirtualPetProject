using System;
using System.Collections.Generic;
using System.Text;

namespace VirtualPet
{
    public class VirtualPetShelter
    {
        public List<OrganicPet> organicPetsInShelter = new List<OrganicPet>();
        public List<RoboticPet> roboPetsInShelter = new List<RoboticPet>();
        public List<Pet> petsInShelter = new List<Pet>();

        public VirtualPetShelter()
        {
           
        }

        public void AddOrganicPetToShelter(OrganicPet organicPet)
        {
            organicPetsInShelter.Add(organicPet);
        }

        public void AddRoboticPetToShelter(RoboticPet roboPet)
        {
            roboPetsInShelter.Add(roboPet);
        }

        public void AddPetToShelter(Pet pet)
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


        public void ListOrganicPetSelection()
        {
            int petId;
            petId = 1;
            Console.WriteLine("Select the pet you want to interact with!");

            foreach(Pet newPet in petsInShelter)
            {
                Console.WriteLine($"{petId}. {newPet.PetName} | {newPet.PetSpecies}");
                petId++;
            }
        }

        public void ListRoboPetSelection()
        {
            int roboPetId;
            roboPetId = 1;
            Console.WriteLine("Select the pet you want to interact with!");

            foreach (Pet roboPet in roboPetsInShelter)
            {
                Console.WriteLine($"{roboPetId}. {roboPet.PetName} | {roboPet.PetSpecies}");
                roboPetId++;
            }
        }

        public RoboticPet SelectRoboticPet()
        {
            int userPetNumber = Convert.ToInt32(Console.ReadLine());
            int roboPetId = (userPetNumber - 1);
            return roboPetsInShelter[roboPetId];
        }

        public OrganicPet SelectOrganicPet()
        {
            int userPetNumber = Convert.ToInt32(Console.ReadLine());
            int organicPetId = (userPetNumber - 1);
            return organicPetsInShelter[organicPetId];
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
            for (int i = 0; i < organicPetsInShelter.Count; i++)
            {
                organicPetsInShelter[i].PlayWithPet();
            }
        }

        public void TakeAllPetsToDoctor()
        {
            for (int i = 0; i < organicPetsInShelter.Count; i++)
            {
                organicPetsInShelter[i].TakeToDoctor();
            }
        }

        public void ShelterContents()
        {
            OrganicPet petsInShelter = new OrganicPet();
        }

    }
}
