using Microsoft.AspNetCore.Mvc;

namespace WebApIUnitTest.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class WeatherForecastController : ControllerBase
    {
        [HttpGet(Name ="Test")]
        public ActionResult Test()
        {
            return Ok();
        }

        public bool IsPrime(int candidate)
        {
            if (candidate < 2)
            {
                return false;
            }
            throw new NotImplementedException("Not fully implemented.");
        }
    }
}
