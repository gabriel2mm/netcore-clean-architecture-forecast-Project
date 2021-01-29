using Forecast.Adapters.Contracts;
using System;
using System.Collections.Generic;
using System.Text;

namespace Forecast.Adapters.Models
{
    public class ForecastAdapter : ITarget
    {
        private readonly ForecastModel _forecast;

        public ForecastAdapter(ForecastModel forecast)
        {
            this._forecast = forecast;
        }

        public Domain.Entity.Forecast GetForecast()
        {
            Forecast.Domain.Entity.Forecast forecast = new Domain.Entity.Forecast()
            {
                Current = new Domain.Entity.Current()
                {
                    Temperature = this._forecast.Current.Temperature.ToString(),
                },
                Location = new Domain.Entity.Location()
                {
                    Country = this._forecast.Location.Country,
                    Localtime= this._forecast.Location.Localtime,
                    Lat = this._forecast.Location.Lat,
                    Lon = this._forecast.Location.Lon,
                    Name= this._forecast.Location.Name,
                    Region = this._forecast.Location.Region,
                    TimeZoneId = this._forecast.Location.TimeZoneId
                },
                Request = new Domain.Entity.Request()
                {
                    Language = this._forecast.Request.Language,
                    Query = this._forecast.Request.Query,
                    Type= this._forecast.Request.Type,
                    Unit = this._forecast.Request.Unit,
                }
            };

            return forecast;
        }
    }
}
