using System.Collections.Generic;
using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using TechnicalRadiation.Models;
using TechnicalRadiation.Models.Dtos;
using TechnicalRadiation.Models.InputModels;
using TechnicalRadiation.Services;

namespace TechnicalRadiation.WebApi.Controllers
{
    [Route("api/categories")]
    [ApiController]
    public class CategoryController : ControllerBase
    {
        private CategoryService _categoryService;
        private string _authorizationHeader;
         public CategoryController(IMapper mapper){

            _categoryService = new CategoryService(mapper);
            _authorizationHeader = "dmVyeSBzZWNyZXQ=";
        }

        [Route("", Name = "GetAllCategories")]
        [HttpGet]

        public IActionResult GetAllCategories() {
            var categories = _categoryService.GetAllCategories();
            return Ok(categories);
       }

       [Route("{id:int}", Name = "GetCategoryById")]
       [HttpGet]
       public IActionResult GetCategoryById(int id){
           var category = _categoryService.GetCategoryById(id);
           if (category == null){return BadRequest("No category with this Id exists.");}
           return Ok(category);
       }

        [Route("", Name = "CreateCategory")]
        [HttpPost]
        public IActionResult CreateCategory([FromBody] CategoryInputModel model) {
            if (!ModelState.IsValid) { return BadRequest("Model formatting is invalid"); }
            var entity = _categoryService.CreateCategory(model);
            
            return CreatedAtRoute("GetCategoryById", new {id = entity.Id}, entity);;
       }

        [Route("{id:int}", Name = "UpdateCategoryById")]
        [HttpPut]
        public IActionResult UpdateCategoryById([FromBody] CategoryInputModel model, int id){
            
            if (Request.Headers["Authorization"] != _authorizationHeader){ return BadRequest("Authorization required."); }
            
            if (!ModelState.IsValid) { return BadRequest("Model formatting is invalid"); }

            try{
                _categoryService.UpdateCategoryById(model, id);
            }
            catch( KeyNotFoundException k){
                return BadRequest("No category with this Id exists.");
            }
    
           return NoContent();
       }


        [Route("{id:int}", Name = "DeleteCategoryById")]
        [HttpDelete]
         public IActionResult DeleteCategoryById(int id){
           
            if (Request.Headers["Authorization"] != _authorizationHeader){ return BadRequest("Authorization required."); }
           
            try{
                _categoryService.DeleteCategoryById(id);
            }
            catch(KeyNotFoundException k){
                return BadRequest("No category with this Id exists.");
            }
            return NoContent();
       }

       [Route("{categoryId:int}/newsItems/{newsItemId:int}", Name = "CreateNewsItemCategoryRelation")]
       [HttpPost]
       public IActionResult CreateNewsItemCategoryRelation(int categoryId, int newsItemId){
            
            if (Request.Headers["Authorization"] != _authorizationHeader){ return BadRequest("Authorization required."); }

            try{
                _categoryService.CreateNewsItemCategoryRelation(categoryId, newsItemId);

            }
            catch(KeyNotFoundException k){
                return BadRequest("Category or news item with provided id does not exist.");
            }
                
            return NoContent();
       }
    }
}