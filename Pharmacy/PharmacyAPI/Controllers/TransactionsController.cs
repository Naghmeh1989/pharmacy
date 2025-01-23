using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using PharmacyAPI.Models;

namespace PharmacyAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TransactionsController : ControllerBase
    {
        private readonly PharmacyDbContext dbContext;

        public TransactionsController(PharmacyDbContext dbContext)
        {
            this.dbContext = dbContext;
        }
    }
}
