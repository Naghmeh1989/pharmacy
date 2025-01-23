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
    }
}
