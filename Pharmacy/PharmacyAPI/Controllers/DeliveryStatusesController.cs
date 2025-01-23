using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using PharmacyAPI.Models;

namespace PharmacyAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DeliveryStatusesController : ControllerBase
    {
        private readonly PharmacyDbContext dbContext;

        public DeliveryStatusesController(PharmacyDbContext dbContext)
        {
            this.dbContext = dbContext;
        }
    }
}
