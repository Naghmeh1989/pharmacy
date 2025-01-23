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
    public class PaymentStatusesController : ControllerBase
    {
        private readonly PharmacyDbContext dbContext;
        private readonly IMapper mapper;

        public PaymentStatusesController(PharmacyDbContext dbContext,IMapper mapper)
        {
            this.dbContext = dbContext;
            this.mapper = mapper;
        }

        [HttpGet]
        public IActionResult GetAll()
        {
            var paymentStatuses = dbContext.PaymentStatuses.ToList();
            var paymentStatusesDto = mapper.Map<List<PaymentStatusDto>>(paymentStatuses);
            return Ok(paymentStatusesDto);
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
            var paymentStatusDto = mapper.Map<PaymentStatusDto>(paymentStatus);
            return Ok(paymentStatusDto);
        }
    }
}
