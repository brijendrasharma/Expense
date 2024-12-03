using ExpenserAPI.utility;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Net;

namespace ExpenserAPI.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class CategoryController : ControllerBase
    {
        private readonly IFileReader _fileReader;
        public CategoryController() {
            string filePath = Path.Combine(Directory.GetCurrentDirectory(), "MockData", "MockData.json");
            _fileReader = new JsonReader(filePath);
        }
        [HttpGet]
        public IActionResult GetCategories()
        {
            var categories = _fileReader.getCategories();
            return Ok(categories);
        }

        [HttpPost]
        [ProducesResponseType(400)]
        [ProducesResponseType(201)]
        public IActionResult AddCategory([FromBody] string category)
        {
            // Placeholder logic; Replace with database logic later
            return CreatedAtAction(nameof(AddCategory), $"Ban gya bhai, {category}");
        }

        [HttpGet("{id}")]
        public IActionResult GetCategorybyId([FromRoute] int id)
        {
            var category = _fileReader.getCategoryById(id);
            if (category == null)
            {
                return NotFound($"Category with ID {id} not found.");
            }
            return Ok(category);
        }
    }
}
