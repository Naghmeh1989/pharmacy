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

        [HttpGet]
        public IActionResult GetAll()
        {
            var payments = dbContext.Payments.ToList();
            return Ok(payments);
        }

        [HttpGet]
        [Route("{id:int}")]
        public IActionResult GetById(int id)
        {
            var payment = dbContext.Payments.Find(id);
            if (payment == null)
            {
                return NotFound();
            }
            return Ok(payment);
        }

    }
}
