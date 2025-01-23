using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using PharmacyAPI.Models;

namespace PharmacyAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BrandsController : ControllerBase
    {
        private readonly PharmacyDbContext dbContext;

        public BrandsController(PharmacyDbContext dbContext)
        {
            this.dbContext = dbContext;
        }

        [HttpGet]
        public IActionResult GetAll()
        {
            var brands = dbContext.Brands.ToList();
            return Ok(brands);
        }

        [HttpGet]
        [Route("{id:int}")]
        public IActionResult GetById(int id)
        {
            var brand = dbContext.Brands.Find(id);
            if (brand == null)
            {
                return NotFound();
            }
            return Ok(brand);
        }
    }
}
