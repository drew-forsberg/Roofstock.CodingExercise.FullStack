using System.Text.Json.Serialization;

namespace Roofstock.CodingExercise.FullStack.Models.Properties
{
    public class ApplianceOwnership
    {
        [JsonPropertyName("refrigerator")]
        public string Refrigerator { get; set; }

        [JsonPropertyName("dishwasher")]
        public string Dishwasher { get; set; }

        [JsonPropertyName("washer")]
        public string Washer { get; set; }

        [JsonPropertyName("dryer")]
        public string Dryer { get; set; }

        [JsonPropertyName("microwave")]
        public string Microwave { get; set; }

        [JsonPropertyName("stove")]
        public string Stove { get; set; }
    }
}