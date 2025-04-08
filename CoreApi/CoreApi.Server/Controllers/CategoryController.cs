using CoreApi.Server.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace CoreApi.Server.Controllers
{
	[Route("api/[controller]")]
	[ApiController]
	public class CategoryController : ControllerBase
	{
		private readonly MyDbContext _context;

		public CategoryController (MyDbContext context)
		{
			_context = context;
		}

		[HttpGet("getCategory")]
		public IActionResult GetCategories() {

			var Categories = _context.Categories.ToList();
			return Ok(Categories);
		}



		[HttpGet("getCategoryById")]
		public IActionResult getCategoryById(int id)
		{
			var category = _context.Categories.FirstOrDefault(c => c.Id == id);
			if (category != null)
			{
				return Ok(category); //200
			}
			else
			{
				return NotFound(); // 404
			}
		}



		[HttpGet("getCategoryByName")]
		public IActionResult getCategoryByName(string name)
		{
			var category = _context.Categories.FirstOrDefault(x => x.Name == name);
			if (category != null)
			{
				return Ok(category);
			}
			else
			{
				return NotFound();
			}
		}

		[HttpGet("getFirstCategory")]
		public IActionResult getFirstCategory()
		{
			var FirstCategory = _context.Categories.FirstOrDefault();
			return Ok(FirstCategory);
		}














	}
}
