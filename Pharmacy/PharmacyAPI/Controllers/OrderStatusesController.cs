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

        [HttpGet]
        public IActionResult GetAll()
        {
            var orderStatuses = dbContext.OrderStatuses.ToList();
            return Ok(orderStatuses);
        }

        [HttpGet]
        [Route("{id:int}")]
        public IActionResult GetById(int id)
        {
            var orderStatus = dbContext.OrderStatuses.Find(id);
            if (orderStatus == null)
            {
                return NotFound();
            }
            return Ok(orderStatus);
        }

    }
}
