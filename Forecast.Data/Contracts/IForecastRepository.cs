using Forecast.Adapters.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Forecast.Adapters.Contracts
{
    public interface IForecastRepository
    {
        public Task<ForecastModel> FetchCurrentForecast();
    }
}
