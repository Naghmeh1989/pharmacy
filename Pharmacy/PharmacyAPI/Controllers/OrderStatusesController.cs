using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using PharmacyAPI.Models;

namespace PharmacyAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class OrderStatusesController : ControllerBase
    {
        private readonly PharmacyDbContext dbContext;

        public OrderStatusesController(PharmacyDbContext dbContext)
        {
            this.dbContext = dbContext;
        }
    }
}
