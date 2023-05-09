using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using WeatherWise.Objects;
namespace WeatherWise.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class WeatherController : ControllerBase
    {
        [HttpGet]
        public IEnumerable<RecordDTO> Get()

        {
            return Enumerable.Range(1, 5).Select(index => new RecordDTO()).ToArray();

        }
    }
}
