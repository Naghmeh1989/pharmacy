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
    public class PriceHistoriesController : ControllerBase
    {
        private readonly PharmacyDbContext dbContext;
        private readonly IMapper mapper;

        public PriceHistoriesController(PharmacyDbContext dbContext,IMapper mapper)
        {
            this.dbContext = dbContext;
            this.mapper = mapper;
        }

        [HttpGet]
        public IActionResult GetAll()
        {
            var priceHistories = dbContext.PriceHistories.ToList();
            var priceHistoriesDto = mapper.Map<List<PriceHistoryDto>>(priceHistories);
            return Ok(priceHistoriesDto);
        }

        [HttpGet]
        [Route("{id:int}")]
        public IActionResult GetById(int id)
        {
            var priceHistory = dbContext.PriceHistories.Find(id);
            if (priceHistory == null)
            {
                return NotFound();
            }
            var priceHistoryDto = mapper.Map<PriceHistoryDto>(priceHistory);
            return Ok(priceHistoryDto);
        }
    }
}
