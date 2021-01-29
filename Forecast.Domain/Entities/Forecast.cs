using System;
using System.Collections.Generic;
using System.Text;

namespace Forecast.Domain.Entity
{
    public class Forecast
    {
        public Request Request { get; set; }
        public Location Location { get; set; }
        public Current Current { get; set; }
    }
}
