using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using PharmacyAPI.Models;

namespace PharmacyAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AddressesController : ControllerBase
    {
        private readonly PharmacyDbContext dbContext;

        public AddressesController(PharmacyDbContext dbContext)
        {
            this.dbContext = dbContext;
        }

        [HttpGet]
        public IActionResult GetAll()
        {
            var addresses = dbContext.Addresses.ToList();
            return Ok(addresses);
        }

        [HttpGet]
        [Route("{id:int}")]
        public IActionResult GetById(int id)
        { 
            var address = dbContext.Addresses.Find(id);
            if (address == null)
            {
                return NotFound();
            }
            return Ok(address);
        }
    }
}
