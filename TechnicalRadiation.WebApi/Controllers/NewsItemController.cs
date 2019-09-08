using Microsoft.AspNetCore.Mvc;

namespace TechnicalRadiation.WebApi.Controllers
{
    [Route("api")]
    [ApiController]
    public class NewsItemController : ControllerBase
    {
        [Route("")]
        [HttpGet]
        public IActionResult GetAllNews() {
            return NoContent();
       }
    } 
}
