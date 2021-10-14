using System.Text.Json.Serialization;

namespace Roofstock.CodingExercise.FullStack.Models.Properties
{
    public class Lease
    {
        [JsonPropertyName("leaseSummary")]
        public LeaseSummary LeaseSummary { get; set; }

        [JsonPropertyName("utilitiesOwnership")]
        public UtilitiesOwnership UtilitiesOwnership { get; set; }

        [JsonPropertyName("applianceOwnership")]
        public ApplianceOwnership ApplianceOwnership { get; set; }
    }
}