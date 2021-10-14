using System;

using Roofstock.CodingExercise.FullStack.Dtos;
using Roofstock.CodingExercise.FullStack.Models.Properties;

namespace Roofstock.CodingExercise.FullStack.Mapping
{
    public static class PropertyMappingExtensions
    {

        /// <summary>
        /// Maps selected properties of Roofstock's complex Property model to a simplified DTO for display purpose
        /// </summary>
        /// <param name="property"></param>
        public static PropertyDto ToDto(this Property property)
        {
            if (property == null)
            {
                throw new ArgumentNullException(nameof(property));
            }

            // The address logic assumes that all properties have an address record with all standard USPS fields
            // That definitely was NOT the case with the MLS data that Coldwell Banker received but Roofstock may be luckier :)
            var address = property.Address == null 
                ? "" 
                : $"{property.Address.Address1}, {property.Address.City}, {property.Address.State} {property.Address.Zip}";

            var yearBuilt = property.Physical?.YearBuilt ?? 0;
            var listPrice = Math.Round(property.Financial?.ListPrice ?? 0, 2);
            var monthlyRent = Math.Round(property.Financial?.MonthlyRent ?? 0);
            var grossYield = listPrice > 0  ? Math.Round(monthlyRent * 12 / listPrice, 4) : 0;

            var propertyDto = new PropertyDto
            {
                Id = property.Id,
                Address = address,
                YearBuilt = yearBuilt,
                ListPrice = listPrice,
                MonthlyRent = monthlyRent,
                GrossYield = grossYield
            };

            return propertyDto;
        }

    }
}
