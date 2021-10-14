using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace Roofstock.CodingExercise.FullStack.Models.Properties
{
    public class Root
    {
        [JsonPropertyName("properties")]
        public List<Property> Properties { get; set; }
    }
}
