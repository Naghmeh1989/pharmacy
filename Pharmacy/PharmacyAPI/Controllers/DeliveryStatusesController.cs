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
    public class DeliveryStatusesController : ControllerBase
    {
        private readonly PharmacyDbContext dbContext;
        private readonly IMapper mapper;

        public DeliveryStatusesController(PharmacyDbContext dbContext,IMapper mapper)
        {
            this.dbContext = dbContext;
            this.mapper = mapper;
        }

        [HttpGet]
        public IActionResult GetAll()
        {
            var deliveryStatuses = dbContext.DeliveryStatuses.ToList();
            var deliveryStatusesDto = mapper.Map<List<DeliveryStatusDto>>(deliveryStatuses);
            return Ok(deliveryStatusesDto);
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
            var deliveryStatusDto = mapper.Map<DeliveryStatusDto>(deliveryStatus);
            return Ok(deliveryStatusDto);
        }
    }
}
