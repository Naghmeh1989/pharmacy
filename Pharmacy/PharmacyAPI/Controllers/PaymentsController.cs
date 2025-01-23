using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using PharmacyAPI.Models;

namespace PharmacyAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PaymentsController : ControllerBase
    {
        private readonly PharmacyDbContext dbContext;

        public PaymentsController(PharmacyDbContext dbContext)
        {
            this.dbContext = dbContext;
        }
    }
}
