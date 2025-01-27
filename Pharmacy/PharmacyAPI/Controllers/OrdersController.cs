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
    public class OrdersController : ControllerBase
    {
        private readonly PharmacyDbContext dbContext;
        private readonly IMapper mapper;
        private readonly IOrderRepository orderRepository;

        public OrdersController(PharmacyDbContext dbContext,IMapper mapper,IOrderRepository orderRepository)
        {
            this.dbContext = dbContext;
            this.mapper = mapper;
            this.orderRepository = orderRepository;
        }

        [HttpGet]
        public IActionResult GetAll() 
        { 
            var orders = orderRepository.GetAll();
            var ordersDto = mapper.Map<List<OrderDto>>(orders);
            return Ok(ordersDto);
        }

        [HttpGet]
        [Route("{id:int}")]
        public IActionResult GetById(int id)
        { 
            var order = dbContext.Orders.Find(id);
            if (order == null)
            {
                return NotFound();
            }
            var orderDto = mapper.Map<OrderDto>(order);
            return Ok(orderDto);
        }

    }
}
