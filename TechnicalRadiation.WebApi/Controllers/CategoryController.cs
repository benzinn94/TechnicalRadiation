using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using TechnicalRadiation.Models;
using TechnicalRadiation.Models.Dtos;
using TechnicalRadiation.Services;

namespace TechnicalRadiation.WebApi.Controllers
{
    [Route("api/categories")]
    [ApiController]
    public class CategoryController : ControllerBase
    {
        private CategoryService _categoryService;

         public CategoryController(IMapper mapper){

            _categoryService = new CategoryService(mapper);
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
           return Ok(_categoryService.GetCategoryById(id));
       }
    }
}