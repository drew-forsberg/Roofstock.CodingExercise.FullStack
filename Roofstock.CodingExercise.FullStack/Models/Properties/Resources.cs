using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace Roofstock.CodingExercise.FullStack.Models.Properties
{
    public class Resources
    {
        [JsonPropertyName("photos")]
        public List<Photo> Photos { get; set; }

        [JsonPropertyName("floorPlans")]
        public List<FloorPlan> FloorPlans { get; set; }

        [JsonPropertyName("threeDRenderings")]
        public List<ThreeDRendering> ThreeDRenderings { get; set; }

        [JsonPropertyName("audios")]
        public List<object> Audios { get; set; }
    }
}