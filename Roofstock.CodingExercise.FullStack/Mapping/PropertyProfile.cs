using AutoMapper;
using Roofstock.CodingExercise.FullStack.DataAccess.Entities;
using Roofstock.CodingExercise.FullStack.Dtos;

namespace Roofstock.CodingExercise.FullStack.Mapping
{
    /// <summary>
    /// Creates automapping between the Property DB entity and DTO
    /// </summary>
    public class PropertyProfile: Profile
    {
        public PropertyProfile()
        {
            CreateMap<Property, PropertyDto>();
            CreateMap<PropertyDto, Property>();
        }
    }
}
