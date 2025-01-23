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
    }
}
