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

        [HttpGet]
        public IActionResult GetAll()
        {
            var paymentStatuses = dbContext.PaymentStatuses.ToList();
            return Ok(paymentStatuses);
        }

        [HttpGet]
        [Route("{id:int}")]
        public IActionResult GetById(int id)
        {
            var paymentStatus = dbContext.PaymentStatuses.Find(id);
            if (paymentStatus == null)
            {
                return NotFound();
            }
            return Ok(paymentStatus);
        }
    }
}
