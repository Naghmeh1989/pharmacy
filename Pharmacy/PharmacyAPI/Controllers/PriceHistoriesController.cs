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
    public class PriceHistoriesController : ControllerBase
    {
        private readonly PharmacyDbContext dbContext;
        private readonly IMapper mapper;
        private readonly IPriceHistoryRepository priceHistoryRepository;

        public PriceHistoriesController(PharmacyDbContext dbContext,IMapper mapper,IPriceHistoryRepository priceHistoryRepository)
        {
            this.dbContext = dbContext;
            this.mapper = mapper;
            this.priceHistoryRepository = priceHistoryRepository;
        }

        [HttpGet]
        public IActionResult GetAll()
        {
            var priceHistories = priceHistoryRepository.GetAll();
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

        [HttpPost]
        public IActionResult Create([FromBody] AddPriceHistoryDto addPriceHistoryDto) 
        {
            var priceHistory = mapper.Map<PriceHistory>(addPriceHistoryDto);
            priceHistoryRepository.Create(priceHistory);
            var priceHistoryDto = mapper.Map<PriceHistoryDto> (priceHistory);
            return Ok(priceHistoryDto);
        }

        [HttpDelete]
        [Route("{id:int}")]
        public IActionResult Delete([FromRoute] int id) 
        {
            var priceHistory = priceHistoryRepository.Delete(id);
            if(priceHistory == null)
            { 
                return NotFound();
            }
            return Ok(mapper.Map<PriceHistoryDto>(priceHistory));
        }

        [HttpPut]
        [Route("{id:int}")]
        public IActionResult Update([FromRoute] int id, [FromBody] UpdatePriceHistoryDto updatePriceHistoryDto)
        {
            var priceHistory = mapper.Map<PriceHistory>(updatePriceHistoryDto);
            priceHistory = priceHistoryRepository.Update(id, priceHistory);
            if (priceHistory == null)
            {
                return NotFound();
            }
            return Ok(mapper.Map<PriceHistoryDto>(priceHistory));
        }
    }
}
