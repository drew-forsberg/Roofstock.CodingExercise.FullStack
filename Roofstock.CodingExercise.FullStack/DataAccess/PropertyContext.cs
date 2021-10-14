using Microsoft.EntityFrameworkCore;
using Roofstock.CodingExercise.FullStack.DataAccess.Entities;

namespace Roofstock.CodingExercise.FullStack.DataAccess
{
    /// <summary>
    /// Entity Framework DbContext for accessing the database
    /// </summary>
    public class PropertyContext : DbContext
    {
        public PropertyContext (DbContextOptions<PropertyContext> options): base(options)
        {
        }

        public DbSet<Property> Properties { get; set; }
    }
}
