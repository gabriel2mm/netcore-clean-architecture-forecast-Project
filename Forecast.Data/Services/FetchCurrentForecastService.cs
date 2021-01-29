using Forecast.Adapters.Contracts;
using Forecast.Adapters.Models;
using Forecast.Domain.Exceptions;
using Forecast.Domain.Usecase;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Forecast.Adapters.Services
{
    public class FetchCurrentForecastService : IFetchCurrentForecast
    {

        private readonly IForecastRepository _repository;
        public FetchCurrentForecastService(IForecastRepository repository)
        {
            this._repository = repository;
        }

        public async Task<Forecast.Domain.Entity.Forecast> Load()
        {
            try
            {
                ForecastModel forecastModel = await _repository.FetchCurrentForecast();
                ITarget target = new ForecastAdapter(forecastModel);
                return target.GetForecast();
            }
            catch(Exception e)
            {
                throw new ServiceUnavailable(String.Format("Não foi possível capturar resultado forecast: [{0}]", e.Message));
            }
        }
    }
}
