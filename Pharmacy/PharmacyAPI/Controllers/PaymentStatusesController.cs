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
    public class PaymentStatusesController : ControllerBase
    {
        private readonly PharmacyDbContext dbContext;
        private readonly IMapper mapper;
        private readonly IPaymentStatusRepository paymentStatusRepository;

        public PaymentStatusesController(PharmacyDbContext dbContext,IMapper mapper,IPaymentStatusRepository paymentStatusRepository)
        {
            this.dbContext = dbContext;
            this.mapper = mapper;
            this.paymentStatusRepository = paymentStatusRepository;
        }

        [HttpGet]
        public IActionResult GetAll()
        {
            var paymentStatuses = paymentStatusRepository.GetAll();
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

        [HttpPost]
        public IActionResult Create([FromBody] AddPaymentStatusDto addPaymentStatusDto)
        {
            var paymentStatus = mapper.Map<PaymentStatus>(addPaymentStatusDto);
            paymentStatusRepository.Create(paymentStatus);
            var paymentStatusDto = mapper.Map<PaymentStatusDto>(paymentStatus);
            return Ok(paymentStatusDto);
        }

        [HttpDelete]
        [Route("{id:int}")]
        public IActionResult Delete([FromRoute] int id) 
        {
            var paymentStatus = paymentStatusRepository.Delete(id);
            if (paymentStatus == null)
            { 
                return NotFound();
            }
            return Ok(mapper.Map<PaymentStatusDto>(paymentStatus));
        }

        [HttpPut]
        [Route("{id:int}")]
        public IActionResult Update([FromRoute] int id, [FromBody] UpdatePaymentStatusDto updatePaymentStatusDto)
        {
            var paymentStatus = mapper.Map<PaymentStatus>(updatePaymentStatusDto);
            paymentStatus = paymentStatusRepository.Update(id, paymentStatus);
            if (paymentStatus == null)
            {
                return NotFound();
            }
            return Ok(mapper.Map<PaymentStatusDto>(paymentStatus));
        }
    }
}
