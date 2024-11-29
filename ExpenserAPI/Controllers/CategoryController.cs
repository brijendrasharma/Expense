using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Net;

namespace ExpenserAPI.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class CategoryController : ControllerBase
    {
        [HttpGet]
        public IActionResult GetCategories()
        {
            string categories = "This is to return Categories";
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
            return Ok();
        }
    }
}
