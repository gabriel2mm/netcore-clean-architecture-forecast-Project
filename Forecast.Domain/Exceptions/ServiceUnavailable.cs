using System;
using System.Collections.Generic;
using System.Text;

namespace Forecast.Domain.Exceptions
{
    public class ServiceUnavailable : Exception
    {
        public ServiceUnavailable(String message) : base(message) { }
    }
}
