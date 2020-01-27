using System;
using Xunit;

namespace VirtualPet.Tests
{
    public class VirtualPetTests
    {
        [Fact]
        public void Can_Create_Pet_Instance()
        {
            new FirstPet();
        }

        [Fact]
        public void Pet_Has_Name()
        {
            // Arrange
            var myPet = new FirstPet();

            // Act
            myPet.PetName = "Byte";

            // Assert
            Assert.Equal("Byte", myPet.PetName);
        }

        [Fact]
        public void Initial_Pet_Hunger_Is_0()
        {
            var myPet = new FirstPet();
            Assert.Equal(0, myPet.Hunger);
        }

        [Fact]
        public void Pet_Hunger_Decreases_By_10()
        {
            var myPet = new FirstPet();
            myPet.Hunger = 10;
            myPet.FeedPet();
            Assert.Equal(0, myPet.Hunger);
        }

        [Fact]
        public void Initial_Pet_Boredom_Is_0()
        {
            var myPet = new FirstPet();
            Assert.Equal(0, myPet.Boredom);
        }

        [Fact]
        public void Pet_Boredom_Decreases_By_10()
        {
            var myPet = new FirstPet();
            myPet.Boredom = 10;
            myPet.PlayWithPet();
            Assert.Equal(0, myPet.Boredom);
        }

        [Fact]
        public void Initial_Pet_Health_Is_10()
        {
            var myPet = new FirstPet();
            Assert.Equal(10, myPet.Health);
        }

        [Fact]
        public void Pet_Health_Increases_By_10()
        {
            var myPet = new FirstPet();
            myPet.Health = 0;
            myPet.TakeToDoctor();
            Assert.Equal(10, myPet.Health);
        }

        [Fact]
        public void Feed_Reduces_AllPets_Hunger_By_10()
        {
            //Arrange
            VirtualPetShelter myShelter = new VirtualPetShelter();
            myShelter.petsInShelter.Add(new FirstPet());
            myShelter.petsInShelter.Add(new FirstPet());
            myShelter.petsInShelter.Add(new FirstPet());

            //Act
            myShelter.FeedAllPets();


            //Assert
            Assert.Equal(-10, myShelter.petsInShelter[0].Hunger);
            Assert.Equal(-10, myShelter.petsInShelter[1].Hunger);
            Assert.Equal(-10, myShelter.petsInShelter[2].Hunger);

        }

        [Fact]
        public void Play_Reduces_AllPets_Boredom_By_10()
        {
            //Arrange
            VirtualPetShelter myShelter = new VirtualPetShelter();
            myShelter.petsInShelter.Add(new FirstPet());
            myShelter.petsInShelter.Add(new FirstPet());
            myShelter.petsInShelter.Add(new FirstPet());

            //Act
            myShelter.PlayWithAllPets();


            //Assert
            Assert.Equal(-10, myShelter.petsInShelter[0].Boredom);
            Assert.Equal(-10, myShelter.petsInShelter[1].Boredom);
            Assert.Equal(-10, myShelter.petsInShelter[2].Boredom);

        }

        [Fact]
        public void Take_All_Pets_To_Doctor_Increases_AllPets_Health_By_10()
        {
            //Arrange
            VirtualPetShelter myShelter = new VirtualPetShelter();
            myShelter.petsInShelter.Add(new FirstPet());
            myShelter.petsInShelter.Add(new FirstPet());
            myShelter.petsInShelter.Add(new FirstPet());

            //Act
            myShelter.TakeAllPetsToDoctor();


            //Assert
            Assert.Equal(20, myShelter.petsInShelter[0].Health);
            Assert.Equal(20, myShelter.petsInShelter[1].Health);
            Assert.Equal(20, myShelter.petsInShelter[2].Health);

        }
    }
    }
