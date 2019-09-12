using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using TechnicalRadiation.Models;
using TechnicalRadiation.Models.Dtos;
using TechnicalRadiation.Services;


namespace TechnicalRadiation.WebApi.Controllers
{
    [Route("api/authors")]
    [ApiController]
    public class AuthorController : ControllerBase
    {
       private AuthorService _authorService;

        public AuthorController(IMapper mapper){

            _authorService = new AuthorService(mapper);
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
            return Ok(_authorService.GetAuthorById(id));
        }
        [Route("{id:int}/newsItems", Name = "GetAuthorNewsItemsById")]
        [HttpGet]
        public IActionResult GetAuthorNewsItemsById(int id){

            return Ok(_authorService.GetAuthorNewsItemsById(id));
        }
    }
}