using System;
using System.Collections.Generic;
using System.Text;
using System.Text.Json.Serialization;

namespace Forecast.Adapters.Models
{
    public class LocationModel
    {
        [JsonPropertyName("name")]
        public string Name { get; set; }

        [JsonPropertyName("country")]
        public string Country { get; set; }

        [JsonPropertyName("region")]
        public string Region { get; set; }

        [JsonPropertyName("lat")]
        public string Lat { get; set; }

        [JsonPropertyName("lon")]
        public string Lon { get; set; }
        
        [JsonPropertyName("timezone_id")]
        public string TimeZoneId { get; set; }

        [JsonPropertyName("localtime")]
        public string Localtime { get; set; }

    }
}
