using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using PharmacyAPI.Models;
using PharmacyAPI.Models.DTOs;
using System.Transactions;

namespace PharmacyAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TransactionsController : ControllerBase
    {
        private readonly PharmacyDbContext dbContext;
        private readonly IMapper mapper;

        public TransactionsController(PharmacyDbContext dbContext,IMapper mapper)
        {
            this.dbContext = dbContext;
            this.mapper = mapper;
        }

        [HttpGet]
        public IActionResult GetAll()
        {
            var transactions = dbContext.Transactions.ToList();
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
    }
}
