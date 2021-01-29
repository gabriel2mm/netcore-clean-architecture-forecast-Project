using System;
using System.Collections.Generic;
using System.Text;
using System.Text.Json.Serialization;

namespace Forecast.Adapters.Models
{
    public class CurrentModel
    {
        [JsonPropertyName("temperature")]
        public int Temperature { get; set; }
    }
}
