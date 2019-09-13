using System.Collections.Generic;
using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using TechnicalRadiation.Models;
using TechnicalRadiation.Models.Dtos;
using TechnicalRadiation.Models.InputModels;
using TechnicalRadiation.Services;


namespace TechnicalRadiation.WebApi.Controllers
{
    [Route("api/authors")]
    [ApiController]
    public class AuthorController : ControllerBase
    {
       private AuthorService _authorService;
       private string _authorizationHeader;

        public AuthorController(IMapper mapper){

            _authorService = new AuthorService(mapper);
            _authorizationHeader = "dmVyeSBzZWNyZXQ=";
        }
        [Route("", Name = "GetAllAuthors")]
        [HttpGet]
        public IActionResult GetAllAuthors() {
            var authors = _authorService.GetAllAuthors();
            return Ok(authors);
       }

        [Route("{id:int}", Name = "GetAuthorById")]
        [HttpGet]
        public IActionResult GetAuthorById(int id){
            var author = _authorService.GetAuthorById(id);
            if (author == null){return BadRequest("No author with this Id exists.");}

            return Ok(author);
        }
        [Route("{id:int}/newsItems", Name = "GetAuthorNewsItemsById")]
        [HttpGet]
        public IActionResult GetAuthorNewsItemsById(int id){

            return Ok(_authorService.GetAuthorNewsItemsById(id));
        }

        [Route("", Name = "CreateAuthor")]
        [HttpPost]
        public IActionResult CreateAuthor([FromBody] AuthorInputModel model) {
            
            if (Request.Headers["Authorization"] != _authorizationHeader){ return BadRequest("Authorization required."); }

            if (!ModelState.IsValid) { return BadRequest("Model formatting is invalid"); }
            var entity = _authorService.CreateAuthor(model);
            
            return CreatedAtRoute("GetAuthorById", new {id = entity.Id}, entity);
       }

        [Route("{id:int}", Name = "UpdateAuthorById")]
        [HttpPut]
        public IActionResult UpdateAuthorById([FromBody] AuthorInputModel model, int id){
            
            if (Request.Headers["Authorization"] != _authorizationHeader){ return BadRequest("Authorization required."); }
            
            if (!ModelState.IsValid) { return BadRequest("Model formatting is invalid"); }

            try{
                _authorService.UpdateAuthorById(model, id);
            }
            catch( KeyNotFoundException k){
                return BadRequest("No author with this Id exists.");
            }
    
           return NoContent();
       }

        [Route("{id:int}", Name = "DeleteAuthorById")]
        [HttpDelete]
         public IActionResult DeleteAuthorById(int id){
           
            if (Request.Headers["Authorization"] != _authorizationHeader){ return BadRequest("Authorization required."); }
           
            try{
                _authorService.DeleteAuthorById(id);
            }
            catch(KeyNotFoundException k){
                return BadRequest("No author with this Id exists.");
            }
            return NoContent();
       }

       [Route("{authorId:int}/newsItems/{newsItemId:int}", Name = "CreateNewsItemAuthorRelation")]
       [HttpPost]
       public IActionResult CreateNewsItemAuthorRelation(int authorId, int newsItemId){
            
            if (Request.Headers["Authorization"] != _authorizationHeader){ return BadRequest("Authorization required."); }

            try{
                _authorService.CreateNewsItemCategoryRelation(authorId, newsItemId);

            }
            catch(KeyNotFoundException k){
                return BadRequest("Author or news item with provided Id does not exist.");
            }
                
            return NoContent();
       }
    }
}