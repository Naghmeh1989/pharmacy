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
    }
}
