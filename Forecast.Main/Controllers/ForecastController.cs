using Forecast.Domain.Usecase;
using Forecast.Main.Factories;
using Forecast.Presentation.Contracts;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Forecast.Main.Controllers
{
    [ApiController]
    [Route("api/[Controller]s")]
    public class ForecastController : ControllerBase
    {
        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            FactoryForecastController factoryForecastController = new FactoryForecastController();
            IController controller = factoryForecastController.MakeForecastController();
            return Ok(await controller.GetAll());
        }
    }
}
