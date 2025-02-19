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
    public class OrderStatusesController : ControllerBase
    {
        private readonly PharmacyDbContext dbContext;
        private readonly IMapper mapper;
        private readonly IOrderStatusRepository orderStatusRepository;

        public OrderStatusesController(PharmacyDbContext dbContext,IMapper mapper,IOrderStatusRepository orderStatusRepository)
        {
            this.dbContext = dbContext;
            this.mapper = mapper;
            this.orderStatusRepository = orderStatusRepository;
        }

        [HttpGet]
        public IActionResult GetAll()
        {
            var orderStatuses = orderStatusRepository.GetAll();
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

        [HttpPost]
        public IActionResult Create([FromBody] AddOrderStatusDto addOrderStatusDto) 
        { 
            var orderStatus = mapper.Map<OrderStatus>(addOrderStatusDto);
            orderStatusRepository.Create(orderStatus);
            var orderStatusDto = mapper.Map<OrderStatusDto>(orderStatus);
            return Ok(orderStatusDto);
        }

        [HttpDelete]
        [Route("{id:int}")]
        public IActionResult Delete([FromRoute] int id) 
        {
            var orderStatus = orderStatusRepository.Delete(id);
            if(orderStatus == null)
            {  
                return NotFound(); 
            }
            return Ok(mapper.Map<OrderStatusDto>(orderStatus));
        }

        [HttpPut]
        [Route("{id:int}")]
        public IActionResult Update([FromRoute] int id, [FromBody] UpdateOrderStatusDto updateOrderStatusDto)
        {
            var orderStatus = mapper.Map<OrderStatus>(updateOrderStatusDto);
            orderStatus = orderStatusRepository.Update(id, orderStatus);
            if (orderStatus == null)
            {
                return NotFound();
            }
            return Ok(mapper.Map<OrderStatusDto>(orderStatus));
        }

    }
}
