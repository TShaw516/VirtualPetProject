using System;
using Xunit;

namespace VirtualPet.Tests
{
    public class VirtualPetTests
    {
        /*[Fact]
        public void PetCreation_Works()
        {
            //Arrange
            FirstPet myPet = new FirstPet();

            //Act
            //Assert
            
        }

        [Fact]
        public void Pet_CanBeNamed()
        {
            // Arrange
            string petName;
            string petSpecies;
            //FirstPet myPet = new FirstPet(petName, petSpecies);

            // Act


            // Assert
            //Assert.Equal(nameInput, myPet.petName);
        }*/

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
        public void Pet_Has_Hunger()
        {
            var myPet = new FirstPet();
            myPet.Hunger = 42;
            Assert.Equal(42, myPet.Hunger);
        }

        [Fact]
        public void Initial_Pet_Hunger_Is_10()
        {
            var myPet = new FirstPet();
            myPet.Hunger = 42;
            Assert.Equal(10, myPet.Hunger);
        }
    }
}
