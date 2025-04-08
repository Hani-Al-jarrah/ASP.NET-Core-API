using CoreApi.Server.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace CoreApi.Server.Controllers
{
	[Route("api/[controller]")]
	[ApiController]
	public class ProductController : ControllerBase
	{

		private readonly MyDbContext _db;

		public ProductController(MyDbContext db)
		{
			_db = db;
		}



		[HttpGet("getProduct")]
		public IActionResult getAllCategory()
		{
			var Products = _db.Products.ToList();
			return Ok(Products);
		}

		[HttpGet("getProductById")]
		public IActionResult getCategoryById(int id)
		{
			var Product = _db.Products.FirstOrDefault(p => p.Id == id);
			if (Product != null)
			{
				return Ok(Product);
			}
			else
			{
				return NotFound();
			}
		}

		[HttpGet("getProductByName")]
		public IActionResult getCategoryByName(string name)
		{
			var Product = _db.Products.FirstOrDefault(x => x.Name == name);
			if (Product != null)
			{
				return Ok(Product);
			}
			else
			{
				return NotFound();
			}
		}

		[HttpGet("getFirstProduct")]
		public IActionResult getFirstCategory()
		{
			var FirstProduct = _db.Products.First();
			return Ok(FirstProduct);
		}

	}
}
