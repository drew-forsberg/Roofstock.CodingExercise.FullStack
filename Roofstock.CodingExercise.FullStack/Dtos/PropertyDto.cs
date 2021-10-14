using System.Text.Json.Serialization;

namespace Roofstock.CodingExercise.FullStack.Dtos
{
    /// <summary>
    /// Simplified representation of Property information including only the fields needed for display to the user
    /// </summary>
    public class PropertyDto
    {
        [JsonPropertyName("id")]
        public int Id { get; set; }

        [JsonPropertyName("address")]
        public string Address { get; set; }

        [JsonPropertyName("yearBuilt")]
        public int YearBuilt { get; set; }

        [JsonPropertyName("listPrice")]
        public double ListPrice { get; set; }

        [JsonPropertyName("monthlyRent")]
        public double MonthlyRent { get; set; }

        [JsonPropertyName("grossYield")]
        public double GrossYield { get; set; }
    }
}
