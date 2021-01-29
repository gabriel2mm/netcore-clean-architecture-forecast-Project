using System;
using System.Collections.Generic;
using System.Text;

namespace Forecast.Adapters.Contracts
{
    public interface ITarget
    {
        public Forecast.Domain.Entity.Forecast GetForecast();
    }
}
