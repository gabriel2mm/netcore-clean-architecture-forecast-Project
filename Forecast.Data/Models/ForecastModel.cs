using System;
using System.Collections.Generic;
using System.Text;
using System.Text.Json.Serialization;

namespace Forecast.Adapters.Models
{
    public class ForecastModel
    {
        [JsonPropertyName("request")]
        public RequestModel Request { get; set; }

        [JsonPropertyName("location")]
        public LocationModel Location { get; set; }

        [JsonPropertyName("current")]
        public CurrentModel Current { get; set; }
    }
}
