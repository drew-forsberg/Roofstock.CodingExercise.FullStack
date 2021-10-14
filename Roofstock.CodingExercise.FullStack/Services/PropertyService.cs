using System.Collections.Generic;
using System.Net.Http;
using System.Text.Json;
using System.Threading.Tasks;
using Roofstock.CodingExercise.FullStack.Models.Properties;

namespace Roofstock.CodingExercise.FullStack.Services
{
    /// <summary>
    /// Provides access to Roofstock's Property API (in this case, just a static JSON file)
    /// </summary>
    public class PropertyService : IPropertyService
    {
        public async Task<IEnumerable<Property>> GetAllProperties()
        {
            using (var httpClient = new HttpClient())
            {
                var response = await httpClient.GetStringAsync("https://samplerspubcontent.blob.core.windows.net/public/properties.json");

                var root = JsonSerializer.Deserialize<Root>(response);

                return root.Properties;
            }
        }
    }
}
