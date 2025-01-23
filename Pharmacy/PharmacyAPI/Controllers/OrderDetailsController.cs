using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using PharmacyAPI.Models;

namespace PharmacyAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class OrderDetailsController : ControllerBase
    {
        private readonly PharmacyDbContext dbContext;

        public OrderDetailsController(PharmacyDbContext dbContext)
        {
            this.dbContext = dbContext;
        }
    }
}
