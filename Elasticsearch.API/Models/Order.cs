

using System.Text.Json.Serialization;

namespace FakeDataSearchApp
{
    internal class Order
    {
        [JsonPropertyName("_id")]
        public int Id { get; set; }
        [JsonPropertyName("food")]
        public EFood Food { get; set; }
        [JsonPropertyName("quantity")]
        public int Quantity { get; set; }
        [JsonPropertyName("price")]
        public int Price { get; set; }
        [JsonPropertyName("total_price")]
        public int TotalPrice { get; set; }
        [JsonPropertyName("order_time")]
        public DateTime OrderTime { get; set; }
        [JsonPropertyName("user")]
        public User User { get; set; } =null!;

    }  
}
