using System.Text.Json.Serialization;

namespace Roofstock.CodingExercise.FullStack.Models.Properties
{
    public class Physical
    {
        [JsonPropertyName("bathRooms")]
        public double BathRooms { get; set; }

        [JsonPropertyName("bedRooms")]
        public double BedRooms { get; set; }

        [JsonPropertyName("parcelNumber")]
        public string ParcelNumber { get; set; }

        [JsonPropertyName("isPool")]
        public bool IsPool { get; set; }

        [JsonPropertyName("lotSize")]
        public int? LotSize { get; set; }

        [JsonPropertyName("squareFeet")]
        public int SquareFeet { get; set; }

        [JsonPropertyName("stories")]
        public object Stories { get; set; }

        [JsonPropertyName("units")]
        public object Units { get; set; }

        [JsonPropertyName("yearBuilt")]
        public int YearBuilt { get; set; }

        [JsonPropertyName("zipYearBuilt")]
        public object ZipYearBuilt { get; set; }
    }
}