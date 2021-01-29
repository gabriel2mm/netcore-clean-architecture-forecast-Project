using System;
using System.Collections.Generic;
using System.Text;

namespace Forecast.Domain.Entity
{
    public class Location
    {
        public string Name { get; set; }
        public string Country { get; set; }
        public string Region { get; set; }
        public string Lat { get; set; }
        public string Lon { get; set; }
        public string TimeZoneId { get; set; }
        public string Localtime { get; set; }
    }
}
