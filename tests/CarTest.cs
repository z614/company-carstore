using System;
using Company.Carstore.Api.Models;
using Xunit;

namespace tests
{
    public class CarTest
    {
        [Fact]
        public void ChangeNumofMiles()
        {
           //Arrange
            var Car = new Car()
            {
                Id = 1, 
                NumOfMiles = "100,112",
            };

            //Act
            var updatedMiles = "101,000";
            car.updatedMiles(updatedMiles);

            //Assert
            var expectedMiles = updatedMiles;
            var actualMiles = car.updatedMiles;
            
            Assert.Equal(expectedPublicationDate, actualPublicationDate);

       
        }
    }
}