using System.Collections.Generic;
using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using TechnicalRadiation.Models;
using TechnicalRadiation.Models.Dtos;
using TechnicalRadiation.Models.InputModels;
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
        
        [Route("", Name = "GetAllNews")]
        [HttpGet]
        public IActionResult GetAllNews() {
            Envelope<NewsItemDto> env = new Envelope<NewsItemDto>(0, 25, _newsItemService.GetAllNews());
            return Ok(env);
       }

       [Route("{id:int}", Name = "GetNewsItemById")]
       [HttpGet]
       public IActionResult GetNewsItemById(int id){
           //TODO: What if there is no item with this id ?

           var newsItem = _newsItemService.GetNewsItemById(id);

           if(newsItem == null){return BadRequest("No news item with this Id exists.");}
           return Ok(_newsItemService.GetNewsItemById(id));
       }

        [Route("", Name = "CreateNewsItem")]
        [HttpPost]
        public IActionResult CreateNewsItem([FromBody] NewsItemInputModel model) {
            if (!ModelState.IsValid) { return BadRequest("Model formatting is invalid"); }
            var entity = _newsItemService.CreateNewsItem(model);
            
            return CreatedAtRoute("GetNewsItemById", new {id = entity.Id}, null);
       }

        [Route("{id:int}", Name = "UpdateNewsItemById")]
        [HttpPut]
        public IActionResult UpdateNewsItemById([FromBody] NewsItemInputModel model, int id){
            if (!ModelState.IsValid) { return BadRequest("Model formatting is invalid"); }

            try{
                _newsItemService.UpdateNewsItemById(model, id);
            }
            catch( KeyNotFoundException k){
                return BadRequest("No news item with this Id exists.");
            }
    
           return NoContent();
       }

       [Route("{id:int}", Name = "DeleteNewsItemById")]
       [HttpDelete]
       public IActionResult DeleteNewsItemById(int id){
           
            try{
                _newsItemService.DeleteNewsItemById(id);
            }
            catch(KeyNotFoundException k){
                return BadRequest("No news item with this Id exists.");
            }
            return NoContent();
       }


    } 
}
