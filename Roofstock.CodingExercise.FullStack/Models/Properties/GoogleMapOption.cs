using System.Text.Json.Serialization;

namespace Roofstock.CodingExercise.FullStack.Models.Properties
{
    public class GoogleMapOption
    {
        [JsonPropertyName("hasStreetView")]
        public bool HasStreetView { get; set; }

        [JsonPropertyName("povHeading")]
        public int PovHeading { get; set; }

        [JsonPropertyName("povPitch")]
        public int PovPitch { get; set; }

        [JsonPropertyName("povLatitude")]
        public double PovLatitude { get; set; }

        [JsonPropertyName("povLongitude")]
        public double PovLongitude { get; set; }
    }
}