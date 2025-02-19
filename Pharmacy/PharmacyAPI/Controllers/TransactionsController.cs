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
    public class TransactionsController : ControllerBase
    {
        private readonly PharmacyDbContext dbContext;
        private readonly IMapper mapper;
        private readonly ITransactionRepository transactionRepository;

        public TransactionsController(PharmacyDbContext dbContext,IMapper mapper,ITransactionRepository transactionRepository)
        {
            this.dbContext = dbContext;
            this.mapper = mapper;
            this.transactionRepository = transactionRepository;
        }

        [HttpGet]
        public IActionResult GetAll()
        {
            var transactions = transactionRepository.GetAll();
            var transactionsDto = mapper.Map<List<TransactionDto>>(transactions);
            return Ok(transactionsDto);
        }

        [HttpGet]
        [Route("{id:int}")]
        public IActionResult GetById(int id)
        {
            var transaction = dbContext.Transactions.Find(id);
            if (transaction == null)
            {
                return NotFound();
            }
            var transactionDto = mapper.Map<TransactionDto>(transaction);
            return Ok(transactionDto);
        }

        [HttpPost]
        public IActionResult Create([FromBody] AddTransactionDto addTransactionDto)
        { 
            var transaction = mapper.Map<Transaction>(addTransactionDto);
            transactionRepository.Create(transaction);
            var transactionDto = mapper.Map<TransactionDto>(transaction);
            return Ok(transactionDto);
        }

        [HttpDelete]
        [Route("{id:int}")]
        public IActionResult Delete([FromRoute] int id) 
        {
            var transaction = transactionRepository.Delete(id);
            if(transaction == null)
            { 
                return NotFound();
            }
            return Ok(mapper.Map<TransactionDto>(transaction));
        }

        [HttpPut]
        [Route("{id:int}")]
        public IActionResult Update([FromRoute] int id, [FromBody] UpdateTransactionDto updateTransactionDto)
        {
            var transaction = mapper.Map<Transaction>(updateTransactionDto);
            transaction = transactionRepository.Update(id, transaction);
            if (transaction == null)
            {
                return NotFound();
            }
            return Ok(mapper.Map<TransactionDto>(transaction));
        }
    }
}
