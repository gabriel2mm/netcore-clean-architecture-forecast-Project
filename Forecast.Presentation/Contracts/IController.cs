using Forecast.Presentation.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Forecast.Presentation.Contracts
{
    public interface IController
    {
        public Task<HttpResponse> GetAll();
    }
}
