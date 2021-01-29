using Forecast.Domain.Entity;
using System;
using System.Collections.Generic;
using System.Text;

namespace Forecast.Presentation.Models
{
    public class HttpResponse
    {
        public int StatusCode { get; set; }
        public dynamic Data { get; set; }

        public HttpResponse(Forecast.Domain.Entity.Forecast forecast)
        {
            this.StatusCode = 200;
            this.Data = forecast;
        }
    }
}
