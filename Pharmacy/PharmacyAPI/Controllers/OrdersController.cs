using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using PharmacyAPI.Models;

namespace PharmacyAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class OrdersController : ControllerBase
    {
        private readonly PharmacyDbContext dbContext;

        public OrdersController(PharmacyDbContext dbContext)
        {
            this.dbContext = dbContext;
        }
    }
}
