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
    public class OrderDetailsController : ControllerBase
    {
        private readonly PharmacyDbContext dbContext;
        private readonly IMapper mapper;
        private readonly IOrderDetailsRepository orderDetailsRepository;

        public OrderDetailsController(PharmacyDbContext dbContext,IMapper mapper,IOrderDetailsRepository orderDetailsRepository)
        {
            this.dbContext = dbContext;
            this.mapper = mapper;
            this.orderDetailsRepository = orderDetailsRepository;
        }

        [HttpGet]
        public IActionResult GetAll()
        {
            var ordersDetails = orderDetailsRepository.GetAll();
            var ordersDetailsDto = mapper.Map<List<OrderDetailsDto>>(ordersDetails);
            return Ok(ordersDetailsDto);
        }

        [HttpGet]
        [Route("{id:int}")]
        public IActionResult GetById(int id)
        { 
            var orderDetails = dbContext.OrderDetails.Find(id);
            if (orderDetails == null)
            {
                return NotFound();
            }
            var orderDetailsDto = mapper.Map<OrderDetailsDto>(orderDetails);
            return Ok(orderDetailsDto);
        }
    }
}
