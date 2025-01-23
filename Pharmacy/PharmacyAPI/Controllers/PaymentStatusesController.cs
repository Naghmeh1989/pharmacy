using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using PharmacyAPI.Models;

namespace PharmacyAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PaymentStatusesController : ControllerBase
    {
        private readonly PharmacyDbContext dbContext;

        public PaymentStatusesController(PharmacyDbContext dbContext)
        {
            this.dbContext = dbContext;
        }
    }
}
