using System;
using System.Collections.Generic;
using System.Text;

namespace Forecast.Domain.Entities
{
    public class Search
    {
        public Guid Id { get; set; }
        public string Term { get; set; }
    }
}
