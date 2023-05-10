using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using WeatherWise.Objects;
namespace WeatherWise.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class WeatherController : ControllerBase
    {
        // IEnumberable  is an interface that you can leverage in .Net.
        // Public or private describes the availability of the method to the application. 
        [HttpGet]
        public IEnumerable<RecordDTO> Get()

        {
            // Range method lives in the Enumberable class, it is defined there.
            return Enumerable.Range(1, 5).Select(index => new RecordDTO()).ToArray();

        }

        //What are you wanting to return?  
        //Write psuedo code in comments to help keep on track.
        //The HttpGet needed a way to diferentiate the requests, hence the need for an "id". 
        [HttpGet("{id}")]
        public RecordDTO GetRecordDTOById(int id)
        {
            var newRecord = new RecordDTO()
            {
                Id = id,
                Temprature = 100,
                LocationId = 1,
                WeatherDescriptionId = 4
            };

            return newRecord;

        }
    }

    //DependencyInjection, Dbsets, database context, services.

}

    
