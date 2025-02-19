using AutoMapper;
using Azure;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using PharmacyAPI.Models;
using PharmacyAPI.Models.DTOs;
using PharmacyAPI.Repositories;

namespace PharmacyAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DeliveryStatusesController : ControllerBase
    {
        private readonly PharmacyDbContext dbContext;
        private readonly IMapper mapper;
        private readonly IDeliveryStatusRepository deliveryStatusRepository;

        public DeliveryStatusesController(PharmacyDbContext dbContext,IMapper mapper,IDeliveryStatusRepository deliveryStatusRepository)
        {
            this.dbContext = dbContext;
            this.mapper = mapper;
            this.deliveryStatusRepository = deliveryStatusRepository;
        }

        [HttpGet]
        public IActionResult GetAll()
        {
            var deliveryStatuses = deliveryStatusRepository.GetAll();
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

        [HttpPost]
        public IActionResult Create([FromBody] AddDeliveryStatusDto addDeliveryStatusDto) 
        { 
            var deliveryStatus = mapper.Map<DeliveryStatus>(addDeliveryStatusDto);
            deliveryStatusRepository.Create(deliveryStatus);
            var deliveryStatusDto = mapper.Map<DeliveryStatusDto>(deliveryStatus);
            return Ok(deliveryStatusDto);
        }

        [HttpDelete]
        [Route("{id:int}")]
        public IActionResult Delete([FromRoute] int id) 
        { 
            var deliveryStatus = deliveryStatusRepository.Delete(id);
            if(deliveryStatus == null)
            {  
                return NotFound();
            }
            return Ok(mapper.Map<DeliveryStatusDto>(deliveryStatus));
        }

        [HttpPut]
        [Route("{id:int}")]
        public IActionResult Update([FromRoute] int id, [FromBody] UpdateDeliveryStatusDto updateDeliveryStatusDto)
        {
            var deliveryStatus = mapper.Map<DeliveryStatus>(updateDeliveryStatusDto);
            deliveryStatus = deliveryStatusRepository.Update(id, deliveryStatus);
            if (deliveryStatus == null)
            {
                return NotFound();
            }
            return Ok(mapper.Map<DeliveryStatusDto>(deliveryStatus));
        }
    }
}
