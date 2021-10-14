using System.Text.Json.Serialization;

namespace Roofstock.CodingExercise.FullStack.Models.Properties
{
    public class Score
    {
        [JsonPropertyName("conditionScore")]
        public object ConditionScore { get; set; }

        [JsonPropertyName("crimeScore")]
        public string CrimeScore { get; set; }

        [JsonPropertyName("neighborhoodScore")]
        public int NeighborhoodScore { get; set; }

        [JsonPropertyName("overallScore")]
        public object OverallScore { get; set; }

        [JsonPropertyName("qualityScore")]
        public object QualityScore { get; set; }

        [JsonPropertyName("schoolScore")]
        public string SchoolScore { get; set; }

        [JsonPropertyName("charterSchoolScore")]
        public string CharterSchoolScore { get; set; }

        [JsonPropertyName("floodRiskScore")]
        public string FloodRiskScore { get; set; }

        [JsonPropertyName("walkabilityScore")]
        public object WalkabilityScore { get; set; }
    }
}