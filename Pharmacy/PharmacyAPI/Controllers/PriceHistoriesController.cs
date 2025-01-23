using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using PharmacyAPI.Models;

namespace PharmacyAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PriceHistoriesController : ControllerBase
    {
        private readonly PharmacyDbContext dbContext;

        public PriceHistoriesController(PharmacyDbContext dbContext)
        {
            this.dbContext = dbContext;
        }

        [HttpGet]
        public IActionResult GetAll()
        {
            var priceHistories = dbContext.PriceHistories.ToList();
            return Ok(priceHistories);
        }

        [HttpGet]
        [Route("{id:int}")]
        public IActionResult GetById(int id)
        {
            var priceHistory = dbContext.PriceHistories.Find(id);
            if (priceHistory == null)
            {
                return NotFound();
            }
            return Ok(priceHistory);
        }
    }
}
