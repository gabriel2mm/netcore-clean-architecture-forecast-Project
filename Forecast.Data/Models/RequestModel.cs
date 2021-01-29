using System;
using System.Collections.Generic;
using System.Text;
using System.Text.Json.Serialization;

namespace Forecast.Adapters.Models
{
    public class RequestModel
    {
        [JsonPropertyName("type")]
        public string Type { get; set; }

        [JsonPropertyName("query")]
        public string Query { get; set; }

        [JsonPropertyName("language")]
        public string Language { get; set; }

        [JsonPropertyName("unit")]
        public string Unit { get; set; }
    }
}
