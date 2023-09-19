

using System.Text.Json.Serialization;

namespace FakeDataSearchApp
{
    internal class Address
    {
        [JsonPropertyName("street")]
        public string Street { get; set; } = null!;
        [JsonPropertyName("building_number")]
        public string BuildingNumber { get; set; } = null!;
        [JsonPropertyName("city")]
        public string City { get; set; } = null!;
        [JsonPropertyName("state")]
        public string State { get; set; } = null!;
        [JsonPropertyName("zip")]
        public string Zip { get; set; } = null!;
        }
}
