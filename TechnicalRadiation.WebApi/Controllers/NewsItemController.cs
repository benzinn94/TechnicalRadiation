using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using TechnicalRadiation.Models;
using TechnicalRadiation.Models.Dtos;
using TechnicalRadiation.Services;

namespace TechnicalRadiation.WebApi.Controllers
{
    [Route("api")]
    [ApiController]
    public class NewsItemController : ControllerBase
    {

        private NewsItemService _newsItemService;
        public NewsItemController(IMapper mapper){

            _newsItemService = new NewsItemService(mapper);
        }
        
        [Route("")]
        [HttpGet]
        public IActionResult GetAllNews() {
            Envelope<NewsItemDto> env = new Envelope<NewsItemDto>(0, 25, _newsItemService.GetAllNews());
            return Ok(env);
       }
    } 
}
