using AutoMapper;
using Azure;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using PharmacyAPI.Models;
using PharmacyAPI.Models.DTOs;

namespace PharmacyAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class OrderStatusesController : ControllerBase
    {
        private readonly PharmacyDbContext dbContext;
        private readonly IMapper mapper;

        public OrderStatusesController(PharmacyDbContext dbContext,IMapper mapper)
        {
            this.dbContext = dbContext;
            this.mapper = mapper;
        }

        [HttpGet]
        public IActionResult GetAll()
        {
            var orderStatuses = dbContext.OrderStatuses.ToList();
            var orderStatusesDto = mapper.Map<List<OrderStatusDto>>(orderStatuses);
            return Ok(orderStatusesDto);
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
            var orderStatusDto = mapper.Map<OrderStatusDto>(orderStatus);
            return Ok(orderStatusDto);
        }

    }
}
