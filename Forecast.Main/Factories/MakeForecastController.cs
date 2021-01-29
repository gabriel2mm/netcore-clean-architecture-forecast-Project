using Forecast.Adapters.Contracts;
using Forecast.Adapters.Services;
using Forecast.Domain.Usecase;
using Forecast.Infraestructure.Repositories;
using Forecast.Presentation.Contracts;
using Forecast.Presentation.Controllers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Forecast.Main.Factories
{
    public class FactoryForecastController 
    {
        public IController MakeForecastController()
        {
            IForecastRepository repository = new ForecastRepository();
            IFetchCurrentForecast fetchCurrentForecast = new FetchCurrentForecastService(repository);
            return new Forecast.Presentation.Controllers.FactoryForecastController(fetchCurrentForecast);
        }
    }
}
