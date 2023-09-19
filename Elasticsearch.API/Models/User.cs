using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace FakeDataSearchApp
{
    internal class User
    {
        [JsonPropertyName("first_name")]
        public string FirstName { get; set; }
        [JsonPropertyName("last_name")]
        public string LastName { get; set; }
        [JsonPropertyName("full_name")]
        public string FullName { get; set; }
        [JsonPropertyName("email_address")]
        public string EmailAddress { get; set; }
        [JsonPropertyName("birthday")]
        public DateTime BirthDay { get; set; }
        [JsonPropertyName("address")]
        public Address Address { get; set; }
        [JsonPropertyName("phone_number")]
        public string PhoneNumber { get; set; }
    }
}
