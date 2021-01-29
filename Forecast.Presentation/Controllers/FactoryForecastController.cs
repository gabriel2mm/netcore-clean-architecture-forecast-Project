using Forecast.Domain.Usecase;
using Forecast.Presentation.Contracts;
using Forecast.Presentation.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Forecast.Presentation.Controllers
{
    public class FactoryForecastController : IController
    {
        private readonly IFetchCurrentForecast _fetchCurrentForecast;
        public FactoryForecastController(IFetchCurrentForecast fetchCurrentForecast) {
            this._fetchCurrentForecast = fetchCurrentForecast;
        }

        public async Task<HttpResponse> GetAll()
        {
            return new HttpResponse(await _fetchCurrentForecast.Load());
        }
    }
}
