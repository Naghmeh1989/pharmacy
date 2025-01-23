using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using PharmacyAPI.Models;

namespace PharmacyAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TransactionStatusesController : ControllerBase
    {
        private readonly PharmacyDbContext dbContext;

        public TransactionStatusesController(PharmacyDbContext dbContext)
        {
            this.dbContext = dbContext;
        }
    }
}
