
using CoreApi.Server.Models;
using Microsoft.AspNetCore.Mvc;
using CoreApi.Server.ICategoryService;
namespace CoreApi.Server.Controllers
{
    [ApiController]
    public class CategoryController : ControllerBase
    {


        private readonly CoreApi.Server.ICategoryService.ICategoryService _categoryService;

        public CategoryController(CoreApi.Server.ICategoryService.ICategoryService categoryService)
        {
            _categoryService = categoryService;
        }

        [HttpGet("getCategory")]
        public IActionResult GetCategories()
        {
            return Ok(_categoryService.GetAll());
        }

        [HttpGet("getCategoryById")]
        public IActionResult GetCategoryById(int id)
        {
            var result = _categoryService.GetById(id);
            return result != null ? Ok(result) : NotFound();
        }

        [HttpGet("getCategoryByName")]
        public IActionResult GetCategoryByName(string name)
        {
            var result = _categoryService.GetByName(name);
            return result != null ? Ok(result) : NotFound();
        }

        [HttpGet("getFirstCategory")]
        public IActionResult GetFirstCategory()
        {
            return Ok(_categoryService.GetFirst());
        }

        [HttpDelete("delete")]
        public IActionResult DeleteCategory(int id)
        {
            bool deleted = _categoryService.Delete(id);
            return deleted ? Ok() : NotFound();
        }
    }
}

