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

        [HttpGet]
        public IActionResult GetAll()
        {
            var deliveryStatuses = dbContext.DeliveryStatuses.ToList();
            return Ok(deliveryStatuses);
        }

        [HttpGet]
        [Route("{id:int}")]
        public IActionResult GetById(int id)
        {
            var deliveryStatus = dbContext.DeliveryStatuses.Find(id);
            if (deliveryStatus == null)
            { 
                return NotFound();
            }
            return Ok(deliveryStatus);
        }
    }
}
