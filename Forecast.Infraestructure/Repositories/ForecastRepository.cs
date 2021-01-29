using Forecast.Adapters.Contracts;
using Forecast.Adapters.Models;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Forecast.Infraestructure.Repositories
{
    public class ForecastRepository : IForecastRepository
    {
        public async Task<ForecastModel> FetchCurrentForecast()
        {
            ForecastModel forecastModel = null;
            HttpClient httpClient = new HttpClient();
            httpClient.Timeout = TimeSpan.FromSeconds(30);

            using (HttpResponseMessage response = await httpClient.GetAsync("http://api.weatherstack.com/current?access_key={seu token aqui}&query=Curitiba"))
            {
                if (response.IsSuccessStatusCode)
                {
                    var content = await response.Content.ReadAsStringAsync();
                    forecastModel = JsonSerializer.Deserialize<ForecastModel>(content);
                }
            }

            return forecastModel;
        }
    }
}
