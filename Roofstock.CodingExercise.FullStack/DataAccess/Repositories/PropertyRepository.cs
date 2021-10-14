using System;
using System.Threading.Tasks;
using Roofstock.CodingExercise.FullStack.DataAccess.Entities;

namespace Roofstock.CodingExercise.FullStack.DataAccess.Repositories
{
    /// <summary>
    /// Encapsulates all database logic to access and modify Property entities
    /// </summary>
    public class PropertyRepository : IPropertyRepository
    {
        private readonly PropertyContext _propertyContext;
        public PropertyRepository(PropertyContext propertyContext)
        {
            _propertyContext = propertyContext;
        }

        public async Task CreateOrUpdate(Property property)
        {
            var existingProperty = await _propertyContext.Properties.FindAsync(property.Id);

            if (existingProperty == null)
            {
                property.DateCreated = DateTimeOffset.UtcNow;
                
                _propertyContext.Properties.Add(property);
            }
            else
            {
                existingProperty.Address = property.Address;
                existingProperty.YearBuilt = property.YearBuilt;
                existingProperty.ListPrice = property.ListPrice;
                existingProperty.MonthlyRent = property.MonthlyRent;
                existingProperty.GrossYield = property.GrossYield;
                existingProperty.DateUpdated = DateTimeOffset.UtcNow;

                _propertyContext.Properties.Update(existingProperty);
            }

            await _propertyContext.SaveChangesAsync();
        }
    }
}
