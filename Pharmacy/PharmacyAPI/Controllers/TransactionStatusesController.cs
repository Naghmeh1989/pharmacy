using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using PharmacyAPI.Models;
using PharmacyAPI.Models.DTOs;

namespace PharmacyAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TransactionStatusesController : ControllerBase
    {
        private readonly PharmacyDbContext dbContext;
        private readonly IMapper mapper;

        public TransactionStatusesController(PharmacyDbContext dbContext,IMapper mapper)
        {
            this.dbContext = dbContext;
            this.mapper = mapper;
        }

        [HttpGet]
        public IActionResult GetAll()
        {
            var transactionStatuses = dbContext.TransactionStatuses.ToList();
            var transactionStatusesDto = mapper.Map<List<TransactionStatusDto>>(transactionStatuses);
            return Ok(transactionStatusesDto);
        }

        [HttpGet]
        [Route("{id:int}")]
        public IActionResult GetById(int id)
        {
            var transactionStatus = dbContext.TransactionStatuses.Find(id);
            if (transactionStatus == null)
            {
                return NotFound();
            }
            var transactionStatusDto = mapper.Map<TransactionStatusDto>(transactionStatus);
            return Ok(transactionStatusDto);
        }
    }
}
