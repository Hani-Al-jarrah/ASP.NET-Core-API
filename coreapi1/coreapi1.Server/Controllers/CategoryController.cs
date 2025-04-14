using coreapi1.Server.DTO;
using coreapi1.Server.Models;
using Microsoft.AspNetCore.Mvc;

namespace coreapi1.Server.Controllers
{
	[Route("api/[controller]")]
	[ApiController]
	public class CategoryController : ControllerBase
	{
		private readonly coreapi1.Server.IDataService.IDataServicecs _dataService;

		public CategoryController(coreapi1.Server.IDataService.IDataServicecs dataService)
		{
			_dataService = dataService;
		}

		// READ
		[HttpGet("getCategories")]
		public IActionResult GetCategories()
		{
			var categories = _dataService.getCategories();
			return Ok(categories);
		}

		// GET BY ID
		[HttpGet("getCategoryById/{id}")]
		public IActionResult GetCategoryById(int id)
		{
			var category = _dataService.getCategoryById(id);
			if (category == null) return NotFound();
			return Ok(category);
		}

		// GET BY NAME
		[HttpGet("getCategoryByName/{name}")]
		public IActionResult GetCategoryByName(string name)
		{
			var categories = _dataService.getCategoryByName(name);
			if (categories == null) return NotFound();
			return Ok(categories);
		}

		// DELETE
		[HttpDelete("deleteCategory/{id}")]
		public bool DeleteCategory(int id)
		{
			var result = _dataService.deleteCategory(id);
			return result;
		}

		// ADD (from form)
		[HttpPost("addCategories")]
		public IActionResult AddCategory([FromForm] AddCategoryRequest addCategory)
		{
			if (addCategory == null) return BadRequest();

			var success = _dataService.addCategory(addCategory);
			if (!success) return BadRequest();

			return Ok(success);
		}

		// UPDATE
		[HttpPut("updateCategory/{id}")]
		public IActionResult UpdateCategory(int id, [FromBody] Category category)
		{
			if (category == null) return BadRequest();

			var updated = _dataService.updateCategory(id, category);
			if (!updated) return NotFound();

			return Ok(category);
		}
	}
}
