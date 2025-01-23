using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using PharmacyAPI.Models;

namespace PharmacyAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TagsController : ControllerBase
    {
        private readonly PharmacyDbContext dbContext;

        public TagsController(PharmacyDbContext dbContext)
        {
            this.dbContext = dbContext;
        }

        [HttpGet]
        public IActionResult GetAll()
        {
            var tags = dbContext.Tags.ToList();
            return Ok(tags);
        }

        [HttpGet]
        [Route("{id:int}")]
        public IActionResult GetById(int id)
        {
            var tag = dbContext.Tags.Find(id);
            if (tag == null)
            {
                return NotFound();
            }
            return Ok(tag);
        }
    }
}
