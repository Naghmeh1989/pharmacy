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

        [HttpGet]
        public IActionResult GetAll()
        {
            var transactionStatuses = dbContext.TransactionStatuses.ToList();
            return Ok(transactionStatuses);
        }

        [HttpGet]
        [Route("{id:int}")]
        public IActionResult GetById(int id)
        {
            var transactionStatus = dbContext.TransactionStatuses.Find(id);
            if (transactionStatus == null)
            {
                return NotFound();
            }
            return Ok(transactionStatus);
        }
    }
}
