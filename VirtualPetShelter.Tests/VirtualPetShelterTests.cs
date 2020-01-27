using System;
using System.Collections.Generic;
using Xunit;

namespace VirtualPetShelter.Tests
{
    public class VirtualPetShelterTests
    {
        [Fact]
        public void Feed_Reduces_AllPets_Hunger_By_10()
        {
            //Arrange
            List<VirtualPetShelterTests> TestList = new List<VirtualPetShelterTests>();
            VirtualPetShelter myShelter = new VirtualPetShelter();
            var hunger = new VirtualPetShelter;
            
            //Act
            TestList.hunger = 10;
            VirtualPetShelter.FeedAllPets()

            //Assert
            Assert.Equal(0, TestList.hunger);
        }
    }
}
