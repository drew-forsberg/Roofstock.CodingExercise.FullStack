using System;
using Roofstock.CodingExercise.FullStack.Mapping;
using Roofstock.CodingExercise.FullStack.Models.Properties;
using Xunit;

namespace Roofstock.CodingExercise.FullStack.Tests.Mapping
{
    public class PropertyMappingExtensionsTest
    {
        [Fact]
        public void ToDto_Should_Throw_ArgumentNullException_When_Property_Is_Null()
        {
            // Act & Assert
            Assert.Throws<ArgumentNullException>(() => default(Property).ToDto());
        }

        [Fact]
        public void ToDto_Should_Return_Expected_Dto_When_Property_Is_Valid()
        {
            // Arrange
            var propertyModel = GetPropertyModel();
            var expectedAddress = $"{propertyModel.Address.Address1}, {propertyModel.Address.City}, {propertyModel.Address.State} {propertyModel.Address.Zip}";
            var expectedListPrice = Math.Round(propertyModel.Financial.ListPrice, 2);
            var expectedMonthlyRent = Math.Round(propertyModel.Financial.MonthlyRent, 2);
            var expectedGrossYield = Math.Round(expectedMonthlyRent * 12 / expectedListPrice, 4);

            // Act
            var result = propertyModel.ToDto();

            // Act & Assert
            Assert.NotNull(result);
            Assert.Equal(propertyModel.Id, result.Id);
            Assert.Equal(expectedAddress, result.Address);
            Assert.Equal(propertyModel.Physical.YearBuilt, result.YearBuilt);
            Assert.Equal(expectedListPrice, result.ListPrice);
            Assert.Equal(expectedMonthlyRent, result.MonthlyRent);
            Assert.Equal(expectedGrossYield, result.GrossYield);
        }

        [Fact]
        public void ToDto_Should_Return_Expected_YearBuilt_When_Physical_Is_Null()
        {
            // Arrange
            var propertyModel = GetPropertyModel();
            propertyModel.Physical = null;

            // Act
            var result = propertyModel.ToDto();

            // Act & Assert
            Assert.NotNull(result);
            Assert.Equal(0, result.YearBuilt);
        }

        [Fact]
        public void ToDto_Should_Return_Expected_Pricing_When_Financial_Is_Null()
        {
            // Arrange
            var propertyModel = GetPropertyModel();
            propertyModel.Financial = null;

            // Act
            var result = propertyModel.ToDto();

            // Act & Assert
            Assert.NotNull(result);
            Assert.Equal(0, result.ListPrice);
            Assert.Equal(0, result.MonthlyRent);
            Assert.Equal(0, result.GrossYield);
        }

        /// <summary>
        /// Returns a valid Property model that can be used and modified for testing
        /// </summary>
        private static Property GetPropertyModel()
        {
            return new Property
            {
                Id = 1,
                Address = new Address
                {
                    Address1 = "2001 Broadway",
                    City = "Oakland",
                    State = "CA",
                    Zip = "94612"
                },
                Physical = new Physical
                {
                    YearBuilt = 1900
                },
                Financial = new Financial
                {
                    ListPrice = 10000000.0001,
                    MonthlyRent = 100000.9999
                }
            };
        }
    }
}
