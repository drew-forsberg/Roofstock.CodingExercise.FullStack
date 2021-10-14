using System.Threading.Tasks;
using Roofstock.CodingExercise.FullStack.DataAccess.Entities;

namespace Roofstock.CodingExercise.FullStack.DataAccess.Repositories
{
    public interface IPropertyRepository
    {
        Task CreateOrUpdate(Property property);
    }
}