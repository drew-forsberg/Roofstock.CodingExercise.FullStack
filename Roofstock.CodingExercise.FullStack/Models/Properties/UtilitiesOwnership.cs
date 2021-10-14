using System.Text.Json.Serialization;

namespace Roofstock.CodingExercise.FullStack.Models.Properties
{
    public class UtilitiesOwnership
    {
        [JsonPropertyName("electric")]
        public string Electric { get; set; }

        [JsonPropertyName("gas")]
        public string Gas { get; set; }

        [JsonPropertyName("water")]
        public string Water { get; set; }

        [JsonPropertyName("garbage")]
        public string Garbage { get; set; }

        [JsonPropertyName("pool")]
        public string Pool { get; set; }

        [JsonPropertyName("landscaping")]
        public string Landscaping { get; set; }

        [JsonPropertyName("pestControl")]
        public string PestControl { get; set; }
    }
}