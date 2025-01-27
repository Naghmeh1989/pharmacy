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
    public class PaymentsController : ControllerBase
    {
        private readonly PharmacyDbContext dbContext;
        private readonly IMapper mapper;
        private readonly IPaymentRepository paymentRepository;

        public PaymentsController(PharmacyDbContext dbContext,IMapper mapper,IPaymentRepository paymentRepository)
        {
            this.dbContext = dbContext;
            this.mapper = mapper;
            this.paymentRepository = paymentRepository;
        }

        [HttpGet]
        public IActionResult GetAll()
        {
            var payments = paymentRepository.GetAll();
            var paymentsDto = mapper.Map<List<PaymentDto>>(payments);
            return Ok(paymentsDto);
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
            var paymentDto = mapper.Map<PaymentDto>(payment);
            return Ok(paymentDto);
        }

    }
}
