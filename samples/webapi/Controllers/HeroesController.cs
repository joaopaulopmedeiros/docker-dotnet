using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace webapi.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class HeroesController : ControllerBase
    {
        [HttpGet]
        public async Task<IActionResult> GetAsync([FromServices] HeroService service)
        {
            var result = await service.GetAsync();
            return Ok(result);
        }
    }
}
