using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using PharmacyAPI.Models;
using PharmacyAPI.Models.DTOs;
using PharmacyAPI.Repositories;

namespace PharmacyAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TransactionStatusesController : ControllerBase
    {
        private readonly PharmacyDbContext dbContext;
        private readonly IMapper mapper;
        private readonly ITransactionStatusRepository transactionStatusRepository;

        public TransactionStatusesController(PharmacyDbContext dbContext,IMapper mapper,ITransactionStatusRepository transactionStatusRepository)
        {
            this.dbContext = dbContext;
            this.mapper = mapper;
            this.transactionStatusRepository = transactionStatusRepository;
        }

        [HttpGet]
        public IActionResult GetAll()
        {
            var transactionStatuses = transactionStatusRepository.GetAll();
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

        [HttpPost]
        public IActionResult Create([FromBody] AddTransactionStatusDto addTransactionStatusDto)
        {
            var transactionStatus = mapper.Map<TransactionStatus>(addTransactionStatusDto);
            transactionStatusRepository.Create(transactionStatus);
            var transactionStatusDto = mapper.Map<TransactionStatusDto>(transactionStatus);
            return Ok(transactionStatusDto);
        }

        [HttpDelete]
        [Route("{id:int}")]
        public IActionResult Delete([FromRoute] int id) 
        {
            var transactionStatus = transactionStatusRepository.Delete(id);
            if (transactionStatus == null)
            {
                return NotFound();
            }
            return Ok(mapper.Map<TransactionStatusDto>(transactionStatus));
        }

        [HttpPut]
        [Route("{id:int}")]
        public IActionResult Update([FromRoute] int id, [FromBody] UpdateTransactionStatusDto updateTransactionStatusDto)
        {
            var transactionStatus = mapper.Map<TransactionStatus>(updateTransactionStatusDto);
            transactionStatus = transactionStatusRepository.Update(id, transactionStatus);
            if (transactionStatus == null)
            {
                return NotFound();
            }
            return Ok(mapper.Map<TransactionStatusDto>(transactionStatus));
        }
    }
}
