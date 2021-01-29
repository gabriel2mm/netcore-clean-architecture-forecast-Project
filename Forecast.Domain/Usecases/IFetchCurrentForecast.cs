using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Forecast.Domain.Entity;

namespace Forecast.Domain.Usecase
{
    public interface IFetchCurrentForecast
    {
        public Task<Forecast.Domain.Entity.Forecast> Load();
    }
}
