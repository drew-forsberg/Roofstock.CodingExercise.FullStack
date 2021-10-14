using System.Collections.Generic;
using System.Threading.Tasks;
using Roofstock.CodingExercise.FullStack.Models.Properties;

namespace Roofstock.CodingExercise.FullStack.Services
{
    public interface IPropertyService
    {
        Task<IEnumerable<Property>> GetAllProperties();
    }
}