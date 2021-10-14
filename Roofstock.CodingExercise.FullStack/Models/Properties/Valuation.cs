using System.Text.Json.Serialization;

namespace Roofstock.CodingExercise.FullStack.Models.Properties
{
    public class Valuation
    {
        [JsonPropertyName("avmBpoValue")]
        public object AvmBpoValue { get; set; }

        [JsonPropertyName("avmBpoAdjValue")]
        public object AvmBpoAdjValue { get; set; }

        [JsonPropertyName("avmBpoDate")]
        public object AvmBpoDate { get; set; }

        [JsonPropertyName("rsAvmValue")]
        public double RsAvmValue { get; set; }

        [JsonPropertyName("rsAvmDate")]
        public object RsAvmDate { get; set; }

        [JsonPropertyName("rsBpoMergeValue")]
        public double? RsBpoMergeValue { get; set; }
    }
}