using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace Roofstock.CodingExercise.FullStack.DataAccess.Entities
{
    /// <summary>
    /// Database entity for storing Property information
    /// </summary>
    public class Property
    {
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Id { get; set; }
        public string Address { get; set; }
        public int YearBuilt { get; set; }
        public double ListPrice { get; set; }
        public double MonthlyRent { get; set; }
        public double GrossYield { get; set; }
        public DateTimeOffset DateCreated { get; set; }
        public DateTimeOffset? DateUpdated { get; set; }
    }
}
